using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// ダメージオブザーバー用インターフェース
/// </summary>
// メソッドをまとめている？
//インターフェースはgameObjectをアクセスおよび継承ができない
public interface IDamage
{
    //このメソッドを使わないと継承先でエラーが出る
    void Damage(int currentHp);
}

/// <summary>
/// プレイヤー基本クラス
/// </summary>
public class Player : MonoBehaviour
{
    //ダメージメソッド呼び出し用オブザーバー
    private List<IDamage> damageObserver = new List<IDamage>();

    //プレイヤーHp
    private int hp = 0;

    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        //プレイヤーのHpの初期設定
        hp = 50;
    }

    /// <summary>
    /// ダメージオブザーバーの追加
    /// 所定のタイミングになったら呼び出される
    /// </summary>
    public void AddDamageObsever(IDamage iDamage)
    {
        //damageObserverリストに追加
        damageObserver.Add(iDamage);
    }

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        //Dキーでダメージを受ける
        if (Input.GetKeyDown(KeyCode.D))
        {
            //()の中に数値でダメージ値を調整できる
            //仮で10ダメージを入れる形とする
            ReceiveDamage(10);
        }
    }

    /// <summary>
    /// ダメージを受けたときの処理
    /// </summary>
    private void ReceiveDamage(int damage)
    {
        //damageObserverリストの数だけループする
        foreach (var observer in damageObserver)
        {
            //Damageメソッドはインターフェースで作ったメソッドである
            //ダメージを受けた時に処理されるメソッド
            observer.Damage(damage);
        }
    }
}
