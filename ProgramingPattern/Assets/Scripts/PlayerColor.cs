using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーの色を変更するクラス
/// </summary>
public class PlayerColor : MonoBehaviour
{
    //プレイヤーのImageUIをアタッチ
    [Header("プレイヤーとなるイメージ")]
    [SerializeField] private Image playerImage = null;

    /// <summary>
    /// プレイヤーイメージの色を変更する
    /// </summary>
    public void ChangeColor(Color color)
    {
        //UIのImageのcolorを代入
        //ChangeColorメソッドの引数で入力した色＝プレイヤーの色になる
        playerImage.color = color;
    }
}
