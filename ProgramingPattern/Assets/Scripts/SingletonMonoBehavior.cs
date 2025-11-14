using System;
using UnityEngine;

/// <summary>
/// MonoBehaviourをテンプレートで指定しないと継承できない
/// </summary>
public class SingletonMonoBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    //staticはクラス依存(staticのため)の変数として扱う
    private static T instance;

    /// <summary>
    /// Instanceは()がないため変数
    /// 変数のため呼び出された時メソッドのような処理がされる
    /// </summary>
    public static T Instance
    {
        //getはメソッドのようなもの
        //Instanceが呼び出された時getの中の処理がされる
        get
        {
            if (instance == null)
            {
                //箱の形
                //MonoBehaviourで継承できるものもTypeに含まれる
                //intやfloatなどいろいろなものを含んだものがType
                //typeofは引数の型を渡すことができる演算子
                //今回はT（テンプレート）を渡しているのでtはテンプレートになる
                Type t = typeof(T);

                //引数で最初に引っかかったもの（宣言したもの）を取得
                instance = (T)FindFirstObjectByType(t);

                //(T)FindFirstObjectByType(t)メソッドの処理でinstanceがnullになったらエラー表示のデバッグログを表示する
                if (instance == null)
                {
                    Debug.LogError(t + "をアタッチしているGameObjectはありません");
                }
            }
            return instance;
        }
    }

    /// <summary>
    /// 親クラスの仮想メソッド
    /// 継承できるメソッド
    /// protectedは継承先にのみアクセスできる修飾子
    /// インスタンス依存のメソッド
    /// </summary>
    virtual protected void Awake()
    {
        //ほかのゲームオブジェクトにアタッチされているか調べる
        //アタッチされている場合は破棄する
        CheckInstance();
    }

    /// <summary>
    /// instanceにnullがあるかをチェックするメソッド
    /// </summary>
    protected bool CheckInstance()
    {
        //instanceがあるかチェックする
        if (instance == null)
        {
            //キャストのasを使用
            //asは作った型を別の型で扱うときに使う
            //instanceをテンプレートに変えてtrueにして返す
            //thisは自分のインスタンス先のことを指している
            //クラス依存の場合にthisがよくつかわれる
            instance = this as T;
            return true;
        }
        //Instanceがある場合trueにして返す
        else if (Instance == this)
        {
            return true;
        }
        //オブジェクトの中身（thisの部分だけ）を削除
        Destroy(this);
        return false;
    }
}
