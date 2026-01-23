using UnityEngine;

//SingletonMonoBehaviorのT（テンプレート）を使用していて、SingletonMonoBehaviorクラスが使用できる
//SingletonMonoBehaviorはMonoBehaviorを継承していてそれも使える
/// <summary>
/// UIの管理クラス
/// それぞれアタッチした指定するUIの表示をする
/// </summary>
public class InGameUIManager : SingletonMonoBehavior<InGameUIManager>
{
    //プレイヤーのImageUIがの色を変更するクラス（PlayerColor）を入れる
    [Header("プレイヤーカラークラス")]
    [SerializeField] private PlayerColor playerColor = null;

    //プレイヤー名を表示するクラス（PlayerName）を入れる
    [Header("プレイヤー名クラス")]
    [SerializeField] private PlayerName playerName = null;

    /// <summary>
    /// プレイヤーの色を変更する
    /// </summary>
    public void ChangeColor(Color color)
    {
        //ChangeColorメソッドを呼び出し、引数にColor + 色の指定をする
        playerColor.ChangeColor(color);
    }

    /// <summary>
    /// プレイヤー名の変更
    /// </summary>
    public void SetPlayerName(string name)
    {
        //SetPlayerNameメソッドを呼び出し、メソッドの引数にプレイヤー名の入力
        playerName.SetPlayerName(name);
    }
}
