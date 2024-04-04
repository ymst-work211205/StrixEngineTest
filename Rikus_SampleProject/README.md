# Rikus_SampleProject

## Overview

- StrixエンジンのUnityチュートリアルを動画を見ながら試してみるリポジトリです。
- 各資料
    - りくのオンラインゲームをつくろう（Youtubeチャンネル） >> [＜実践編＞3Dオンラインゲーム開発～Unity～](https://www.youtube.com/playlist?list=PL0dSnTK8ZfqSLrtD9PmjMrLOLpkEVeVFZ)
    - りくの開発ブログの参考記事の直リンク
        - [Top](https://www.strixengine.com/blog/2-sample-projects-unity/#unity-project)
            - ここのリンクは全てYoutubeチャンネルへのリンク
            - まずはこちらの動画をチェックして、そのあとに下記のコード説明を見ながら試してみましょう。
        - [解説動画の実践方法開設](https://www.strixengine.com/blog/rikus-unity-sample-project-update/)
            - こちらにサンプルプロジェクト（.Unity）と実際のコードの説明あります
            - [24/3/27]時点で動作確認出来ました ※動作確認時の各ツールのバージョンは以下
    - [StrixCloud](https://www.strixcloud.net/app/login)
        - 同期用のサーバはこちらでレンタルします。アカウントを作成してください。
        - 無料で利用できるコースがあります（制限あり。1ヵ月間未使用で自動停止）
        - UnityにimportするSDKやドキュメントもこちらから。
- 大まかな流れ
    - StrixCloudにて同期用サーバを用意して起動する
    - クライアント側へ通信処理コードを追加していく
        - 0.StrixSDKをimport
        - 1.サーバとの接続確認
        - 2.キャラの移動、アニメーション同期
        - 3.オブジェクト同期
        - 4.エフェクト同期
        - 5.チャット機能
    
## Versions

動作確認時のバージョンは以下
|ツール|バージョン|memo|
|---|---|---|
|Unity|2020.3.25f1(LTS)||
|VisualStudio|Community 2022(64bit) 17.9.5|エディタ起動時にプロジェクトのバージョンupの確認があった。そのまま更新したが問題無し。|
|Strix|StrixUnitySDK 1.5.2||
|Microsoft .NET Framework|4.8.09032||
||||

## メモ

【！】APPIDなどの設定をそのままコミットしてありますが、サーバは停止してあるし無料枠だしいいか。。

### カリキュラムを全部通してみて

- 特にハマることは無く動作確認まで出来た。
- Youtubeの内容は見た目などかなりサンプルとは違うので、Blog側の記載内容も確認しつつ進めましょう。

### 動作確認方法

- [Build Setting] からexeをビルドして、UnityEditorとexeの多重起動で確認した。
    - ※入力系が両方のWindowで取られてしまって少し面倒だったけどお試しなので詳細な対策などは割愛する。

### いったん見て見ぬふりした挙動不審な箇所

※本プロジェクトはお試しなので詳細な調査は割愛する。

- 同じ部屋にconnectしたときにボールオブジェクトの数がプレイヤーごとで違う
    - 2つあるが1つは同期されてない
- 吹き出しは同期されたがチャットログの方に他者の発言内容が追記されない
    - 多分、VisualStudio側とUnityEditor側で保存してからBuildしなかったせいだと思う。最終的には問題無くなった。

### 【余談】gitで不要なファイルをAddしてしまった場合に取り消したい

- [こちらの記事](https://www-creators.com/archives/1282)を参考

コミット前ならこのコマンドを実行すればOK
```
git reset .
```


## 更新履歴

- [23/3/27] README新規作成

