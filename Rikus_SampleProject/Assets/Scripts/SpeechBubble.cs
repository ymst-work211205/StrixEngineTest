using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechBubble : MonoBehaviour
{
    [SerializeField] GameObject nameTexBubble;
    [SerializeField] Text nameText = null;

    [SerializeField] GameObject chatTexBubble;
    [SerializeField] Text chatText;

    // チャット吹き出しの生存時間
    [SerializeField] float lifeTime = 3.0F;

    // チャット吹き出しの計算を行うか？
    [SerializeField] bool isActive = false;

    // 表示されてからのチャット吹き出しの経過時間
    private float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        nameTexBubble.SetActive(false);
        chatTexBubble.SetActive(false);
    }

    public void SetNameTextBubble(string text)
    {
        nameText.text = text;
        nameTexBubble.SetActive(true);
    }
    public void SetChatTextBubble(string text)
    {
        elapsedTime = 0;
        chatText.text = text;
        chatTexBubble.SetActive(true);
        isActive = true;
    }

    private void FixedUpdate()
    {
        if(isActive == true)
        {
            // 経過時間を更新
            elapsedTime += Time.fixedDeltaTime;
        }
    }

    private void Update()
    {
        //常にカメラの方向に向ける
        transform.forward = Camera.main.transform.forward;

        if (isActive == true)
        {
            // 経過時間による破壊チェック
            if (elapsedTime >= lifeTime)
            {
                chatTexBubble.SetActive(false);
            }
        }
    }
}
