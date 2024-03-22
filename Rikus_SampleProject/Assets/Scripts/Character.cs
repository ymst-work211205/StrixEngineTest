using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static SampleControls;//キー入力判定スクリプト（Assets/InputSystem/SampleControls.cs）

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour, IPlayerControlActions, ICameraControlActions, ICommonActions
{
    // カメラ回転制限Struct
    [Serializable]
    public struct CameraDragLimit
    {
        [Range(-180, 0)] public float min;
        [Range(0, 180)] public float max;
    }

    // キャラクターコントローラー
    CharacterController controller;

    // アニメーター
    Animator _animator;
    // アニメーターステート
    AnimatorStateInfo currentBaseState;

    // カメラ回転の原点
    [SerializeField] Transform cameraPivot;

    // カメラ回転の補正倍率
    [SerializeField] float cameraSensitivity;

    // カメラの回転制限
    [SerializeField] CameraDragLimit cameraDragLimit;

    // キャラクターの移動と回転速度
    [SerializeField] float playerMoveSpeed;
    [SerializeField] float playerRotateSpeed;

    // 矢の発射位置
    [SerializeField] Transform firePos;

    // 矢のプレハブ
    [SerializeField] Bullet bulletObject;

    // エフェクトのプレハブ
    [SerializeField] Effect effectParticle;

    [SerializeField] Chat chat;

    // キャラクター名とチャットの吹き出しのプレハブ
    [SerializeField] SpeechBubble speechBubble;

    // 移動キーの入力値
    Vector3 moveDirection;

    // カメラ回転の入力値
    Vector3 cameraDragValue;

    // NewInputSystem（キー入力判定スクリプト）
    SampleControls inputControls;

    // Animatorがどのステートを再生しているかの識別に使用する値
    static int idleState = Animator.StringToHash("Base Layer.Idle");
    
    /// <summary>
    /// キー入力：プレイヤーの移動
    /// <para>対応キー：WASD</para>
    /// </summary>
    /// <param name="context"></param>
    public void OnMove(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<Vector2>().normalized;
        moveDirection.x = value.x;
        moveDirection.y = 0;
        moveDirection.z = value.y;
    }

    /// <summary>
    /// キー入力：レストポーズ（エモートアクション）
    /// <para>対応キー：Space</para>
    /// </summary>
    /// <param name="context"></param>
    public void OnRest(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            //待機（立ち）状態のときのみ、エモートアクションを再生する
            if (currentBaseState.fullPathHash == idleState)
            {
                if (Keyboard.current.spaceKey.wasPressedThisFrame)
                {
                    // emoteID1～3のいずれかのエモートアクションを再生する
                    PlayEmote(UnityEngine.Random.Range(1, 4));
                }
            }
        }
    }
    /// <summary>
    /// エモートアクション再生
    /// </summary>
    /// <param name="emoteID">エモート指定 1～3の整数</param>
    private void PlayEmote(int emoteID)
    {
        _animator.SetInteger("emoteID", emoteID);
        _animator.SetTrigger("Emote");
    }

    /// <summary>
    /// マウス入力：カメラドラッグ    
    /// </summary>
    /// <param name="context"></param>
    public void OnDrag(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<Vector2>();
        cameraDragValue.x = value.y;
        cameraDragValue.y = -value.x;
        cameraDragValue.z = 0;

        if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.upArrowKey.isPressed || Keyboard.current.leftArrowKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            cameraDragValue *= 6.0F;
        }
    }

    /// <summary>
    /// マウスボタン0入力：矢を発射する
    /// </summary>
    /// <param name="context"></param>
    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            CallShootArrow(firePos.position, firePos.rotation);
        }
    }
    /// <summary>
    /// 矢を発射する処理（「楓ちゃんが作ってくれた処理」の呼び出しなど）
    /// </summary>
    /// <param name="position">発射位置</param>
    /// <param name="rotation">発射角度</param>
    private void CallShootArrow(Vector3 position, Quaternion rotation)
    {
        var bullet = Instantiate<Bullet>(bulletObject, position, rotation, null);
        // 自キャラクターのコリジョンとは当たらないように設定する
        Physics.IgnoreCollision(controller, bullet.HitCollider);
        bullet.Shoot();
    }

    /// <summary>
    /// 矢が当たった
    /// </summary>
    /// <param name="effPos">表示エフェクト位置情報</param>
    public void OnHit(Transform effPos)
    {
        PlayEffect(effPos.position, effPos.rotation);
    }

    /// <summary>
    /// （矢が当たったので）ヒットエフェクトを再生する
    /// </summary>
    /// <param name="position">表示エフェクト位置</param>
    /// <param name="rotation">表示エフェクト角度</param>
    private void PlayEffect(Vector3 position, Quaternion rotation)
    {
        //エフェクトのオブジェクトを生成し、指定位置に配置する
        var effObj = Instantiate<Effect>(effectParticle, position, rotation, null);
        //エフェクトの再生を開始する
        effObj.PlayEffect();

        //ダメージモーションも再生する
        if (!_animator.IsInTransition(0))
        {
            _animator.SetTrigger("Damaged");
        }
    }

    private void Start()
    {
        // Component取得
        controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();

        // InputSystemのセットアップ
        inputControls = new SampleControls();
        inputControls.PlayerControl.SetCallbacks(this);
        inputControls.CameraControl.SetCallbacks(this);
        inputControls.Common.SetCallbacks(this);
        inputControls.Enable();
    }

    private void FixedUpdate()
    {
        UpdateTransform();
    }

    /// <summary>
    /// 移動を含めた様々なパラメーターの更新
    /// </summary>
    private void UpdateTransform()
    {
        // アニメーターの現在のステートを取得
        currentBaseState = _animator.GetCurrentAnimatorStateInfo(0);

        // カメラの現在の回転を取得
        var rot = cameraPivot.rotation.eulerAngles;

        // カメラ回転用にマウスの入力値に補正をかける (入力値 * 補正倍率 * Time.fixedDeltaTime)
        var input = cameraDragValue * cameraSensitivity * Time.fixedDeltaTime;

        // X
        rot.x -= input.x;
        if (rot.x > 180) rot.x -= 360;
        // X軸回転はcameraDragLimitで制限する
        rot.x = Mathf.Clamp(rot.x, cameraDragLimit.min, cameraDragLimit.max);

        // Y
        rot.y -= input.y;

        // Z
        rot.z = 0;

        // カメラ用のQuaternion
        var r1 = Quaternion.Euler(rot);

        // 移動入力値が0以上なら
        if (moveDirection.magnitude > 0)
        {
            // キャラクターのQuaternion(カメラのXZ軸を考慮しない)
            var r2 = Quaternion.Euler(0, rot.y, 0);

            // CharacterControllerの回転を強制的に書き換える
            controller.enabled = false;
            controller.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(r2 * moveDirection), playerRotateSpeed);
            controller.enabled = true;

            // キャラクター移動
            controller.Move(r2 * moveDirection * playerMoveSpeed * Time.fixedDeltaTime);
        }

        // キャラクターが回転しきったらカメラを回転
        cameraPivot.rotation = r1;

        // アニメーターに現在の値をセットする
        _animator.SetFloat("Speed", moveDirection.magnitude > 0 ? 3 : 0);
        _animator.SetFloat("Direction", 0);

        // 矢の発射位置をカメラとキャラクターの向きに合わせて回転
        firePos.rotation = Quaternion.Euler(rot.x, transform.eulerAngles.y, 0);
    }

    private void OnDestroy()
    {
        // オブジェクト破壊時にコントロールも破棄する
        inputControls.Dispose();
    }

    /// <summary>
    /// キー入力：ゲームを終了する
    /// <para>対応キー：Esc</para>
    /// </summary>
    /// <param name="context"></param>
    public void OnExitGame(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }

    /// <summary>
    /// キー入力：カーソルを表示する
    /// <para>対応キー：LeftAlt</para>
    /// </summary>
    /// <param name="context"></param>
    public void OnEscapeCursor(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Cursor.visible = !Cursor.visible;
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
        }
    }
}