using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static SampleControls;

public class Chat : MonoBehaviour, IChatActions
{
    // チャット入力欄
    [SerializeField] InputField chatInputField;

    // チャットログ表示GameObject
    [SerializeField] RectTransform chatLogBox;

    // チャットログ表示テキストプレハブ
    [SerializeField] ChatLogItem chatLogPrefab;

    // キャラクター名とチャットの吹き出しのプレハブ
    [SerializeField] SpeechBubble speechBubble;

    // InputSystem
    private SampleControls inputControls;

    private void Start()
    {
        // InputSystemのセットアップ
        inputControls = new SampleControls();
        inputControls.Chat.SetCallbacks(this);
        inputControls.Enable();
    }

    private void OnDestroy()
    {
        // オブジェクト破壊時にコントロールも破棄する
        inputControls.Dispose();
    }

    /// <summary>
    /// キー入力：チャットを入力する
    /// <para>対応キー：Enter</para>
    /// </summary>
    /// <param name="context"></param>
    public void OnEnterChat(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            // チャット入力にフォーカスされてなければ
            if (!chatInputField.isFocused)
            {
                // チャットを入力状態にする
                chatInputField.Select();
            }
        }
    }

    /// <summary>
    /// キー入力：チャットを送信する
    /// <para>対応キー：Enter</para>
    /// </summary>
    /// <param name="context"></param>
    public void OnSendChat(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            // チャット入力にフォーカスされていれば
            if (chatInputField.isFocused)
            {
                if (chatInputField.text != "")
                {
                    // チャットを送る
                    SendChat("", chatInputField.text, DateTime.Now);
                    // 吹き出しを表示登録
                    SetHukidashi(chatInputField.text);

                    // 入力を空にする
                    chatInputField.text = "";
                }
            }
        }
    }

    /// <summary>
    /// チャットログを表示する
    /// </summary>
    /// <param name="name">送信者名</param>
    /// <param name="message">チャットテキスト</param>
    /// <param name="time">送信時間</param>
    public void SendChat(string name, string message, DateTime time)
    {
        // ログの追加
        var chatLogItem = Instantiate(chatLogPrefab, chatLogBox);
        chatLogItem.SetChat(name, message, time);
    }

    /// <summary>
    /// 吹き出しにチャットを表示する
    /// </summary>
    /// <param name="message">チャットテキスト</param>
    public void SetHukidashi(string message)
    {
        // 吹き出しの登録
        speechBubble.SetChatTextBubble(message);        
    }
}
