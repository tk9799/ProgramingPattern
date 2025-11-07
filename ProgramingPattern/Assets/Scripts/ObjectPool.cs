using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 汎用オブジェクトプール
/// "T"はテンプレートのT
/// 制限を付けている
/// ComponentはInspector内にあるTransformやRigidBodyなどのGameObjectの部品のことを表す
/// Component内にある部品を継承する
/// </summary>
public class ObjectPool<T> where T : Component
{
    //生成プレハブ
    private T prefab = null;

    //プール管理キュー
    private Queue<T> pool = new Queue<T>();

    //生成オブジェクトをまとめる親トランスフォーム
    private Transform parent = null;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ObjectPool(T prefab, int initialSize, Transform parent =null)
    {
        //プレハブと親を設定
        this.prefab = prefab;
        this.parent = parent;

        //初期生成
        for(int i = 0; i < initialSize; i++)
        {
            //オブジェクトを生成するメソッドを呼び出す
            T obj = CreateNewObject();

            //キューの中に追加する
            pool.Enqueue(obj);
        }
    }

    /// <summary>
    /// 新規オブジェクトを生成
    /// </summary>
    private T CreateNewObject()
    {
        //オブジェクトを生成
        T obj = GameObject.Instantiate(prefab, parent);

        //生成した後非表示
        obj.gameObject.SetActive(false);
        return obj;
    }

    //オブジェクトを取り出す
    public T Get()
    {
        //プールにオブジェクトがあればプールから取得
        if (pool.Count > 0)
        {
            //キューから登録を外す
            T obj=pool.Dequeue();
            obj.gameObject.SetActive(true);
            return obj;
        }
        else
        {
            //足りない場合は新しく生成する
            return CreateNewObject();
        }
    }

    /// <summary>
    /// オブジェクトを返却する
    /// </summary>
    public void Release(T obj)
    {
        //オブジェクトを非アクティブにして再度登録する
        obj.gameObject.SetActive(false);

        //キューに登録
        pool.Enqueue(obj);
    }
}
