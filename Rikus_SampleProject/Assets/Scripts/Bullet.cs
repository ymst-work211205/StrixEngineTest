using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    // 重力
    [SerializeField] float gravity = -9.8F;

    // 発射の強さ
    [SerializeField] float power = 10.0F;

    // 矢の生存時間
    [SerializeField] float lifeTime = 30.0F;

    // 矢の計算を行うか？
    [SerializeField] bool isActive = false;

    // 矢のコライダー
    private CapsuleCollider hitCollider;
    public CapsuleCollider HitCollider { get => hitCollider; }

    // 矢のRigidBody
    private Rigidbody rigidBody;

    // 発射されてからの矢の経過時間
    private float elapsedTime = 0;

    // 矢の加速度
    private Vector3 velocity;

    // 初速
    private float initVelocity;

    // 打ち出した角度
    private float initRadian;

    // 打ち出した時の前ベクトル
    private Vector3 forward;

    private void Awake()
    {
        hitCollider = GetComponent<CapsuleCollider>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (isActive)
        {
            // 加速度を再計算
            velocity = forward * power * Mathf.Cos(initRadian);
            velocity.y += initVelocity + gravity * elapsedTime;

            if (velocity.magnitude > 0)
            {
                // 加速度の更新
                rigidBody.velocity = velocity;
            }
        }
        // 経過時間を更新
        elapsedTime += Time.fixedDeltaTime;
    }

    private void Update()
    {
        if (isActive)
        {
            if (velocity != Vector3.zero)
            {
                // 矢を移動に沿って傾ける
                transform.rotation = Quaternion.LookRotation(velocity.normalized);
            }
        }
        // 経過時間による破壊チェック
        if (elapsedTime >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isActive)
        {
            var player = collision.gameObject.GetComponent<Character>();
            if (player)
            {
                // 当たったのがプレイヤーなら、ヒット処理に移行する
                HitPlayer(player);
            }
            else
            {
                // 当たったのが障害物なら、矢の動きを止める
                HitObstacle();
            }
        }
    }

    /// <summary>
    /// 発射する
    /// </summary>
    public void Shoot()
    {
        initRadian = Mathf.DeltaAngle(transform.eulerAngles.x, 0) * Mathf.Deg2Rad;
        forward = new Vector3(transform.forward.x, 0, transform.forward.z);
        initVelocity = power * Mathf.Sin(initRadian);
        rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
        isActive = true;
    }

    /// <summary>
    /// 障害物に当たった時
    /// </summary>
    private void HitObstacle()
    {
        isActive = false;
        // 矢の物理演算や当たり判定を止める
        hitCollider.enabled = false;
        rigidBody.constraints = RigidbodyConstraints.FreezeAll;
    }
    /// <summary>
    /// プレイヤーに当たった時
    /// </summary>
    /// <param name="player">矢が当たったCharacter</param>
    private void HitPlayer(Character player)
    {
        // 矢が当たった位置にヒットエフェクトを表示させる
        player.OnHit(gameObject.transform);
        // 矢を消す
        Destroy(gameObject);
    }

}