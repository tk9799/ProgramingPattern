using UnityEngine;
using TMPro;

/// <summary>
/// プレイヤー名UIを変更するクラス
/// </summary>
public class PlayerName : MonoBehaviour
{
    [Header("プレイヤー名テキストフィール")]
    [SerializeField] private TMP_Text playerNameTextField = null;

    /// <summary>
    /// プレイヤー名設定
    /// </summary>
    public void SetPlayerName(string name)
    {
        //SetPlayerNameメソッドの引数をTMPのテキストに代入
        //引数で入力したもの＝プレイヤー名UIになる
        playerNameTextField.text = name;
    }
}
