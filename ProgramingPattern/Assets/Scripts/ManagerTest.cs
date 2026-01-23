using UnityEngine;

/// <summary>
/// Managerクラスを呼び出すクラス
/// それぞれのUIの色や名前の変更をする
/// </summary>
public class ManagerTest : MonoBehaviour
{
    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        //プレイヤー名変更
        //SetPlayerNameメソッドの引数にstringの引数を入れているため文字列型の物を入れる
        InGameUIManager.Instance.SetPlayerName("tanaka tarou");

        //プレイヤーカラー変更
        //ChangeColorメソッドの引数にColorを入れているため色の指定をする
        InGameUIManager.Instance.ChangeColor(Color.blue);
    }
}
