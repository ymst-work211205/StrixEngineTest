using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatLogItem : MonoBehaviour
{
    // 送信者 名前テキスト
    [SerializeField] Text nameText;
    // チャットテキスト
    [SerializeField] Text messageText;
    // 受信 時間テキスト
    [SerializeField] Text timeText;

    /// <summary>
    /// ログテキストを設定する
    /// </summary>
    /// <param name="name">送信者名</param>
    /// <param name="message">チャットテキスト</param>
    /// <param name="time">送信時間</param>
    public void SetChat(string name, string message, DateTime time)
    {
        if(nameText != null)
        {
            nameText.text = name;
        }
        if(messageText != null)
        {
            messageText.text = message;
        }
        if(timeText != null)
        {
            timeText.text = time.Hour.ToString() + ":" + time.Minute.ToString() + "." + time.Second.ToString();
        }
    }
}