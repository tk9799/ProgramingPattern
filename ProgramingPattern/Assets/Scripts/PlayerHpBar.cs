using UnityEngine;

/// <summary>
/// プレイヤーHPバークラス
/// </summary>
//インターフェースを作ったPlayerクラスを継承しなければ使えない
//インターフェースに設定されているメソッドを実装しないとエラーが出てしまう
public class PlayerHpBar : MonoBehaviour,IDamage
{
    [Header("Playerクラス")]
    [SerializeField] private Player player = null;

    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        //オブザーバー登録
        //自分のインスタンス
        player.AddDamageObsever(this);
    }

    /// <summary>
    /// ダメージ処理
    /// </summary>
    //インターフェースで作ったメソッド
    public void Damage(int currentHp)
    {
        Debug.Log("ダメージバー変更");
    }
}
