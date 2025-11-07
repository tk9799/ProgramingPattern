using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 弾の管理をするスクリプト
/// 弾を出現、消す処理をしている
/// </summary>
public class BulletManager : MonoBehaviour
{
    //unity内に表示するオブジェクトをアタッチする
    [Header("プール化するオブジェクトプレハブ")]
    public GameObject bullet = null;

    //オブジェクトプール
    private ObjectPool<Bullet> bulletPool = null;

    //借りているオブジェクト保管用リスト
    private List<Bullet> bulletList = new List<Bullet>();

    //位置補正用
    private float offsetPosition = 0.0f;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        //オブジェクトプール内に一定数生成した弾を子オブジェクトにする
        bulletPool = new ObjectPool<Bullet>(bullet.GetComponent<Bullet>(), 100, transform);
    }

    /// <summary>
    /// 更新
    /// </summary>
    void Update()
    {
        //Fキーを押して一個出現させる
        if (Input.GetKeyDown(KeyCode.F))
        {
            //プールのオブジェクトを取り出す
            Bullet obj=bulletPool.Get();

            //取り出したオブジェクトの座標を指定する
            obj.transform.position = new Vector3(offsetPosition, 0.0f, 0.0f);

            //プールから取り出したしたオブジェクトをListに加える
            bulletList.Add(obj);

            //生成する位置が被らないように次に表示する座標を更新
            offsetPosition += 1.0f;
        }

        //Rキーを押して一番古い弾を消す
        if (Input.GetKeyDown(KeyCode.R))
        {
            //プールのオブジェクトをプールに返却する
            bulletPool.Release(bulletList[0]);

            //RemoveAtでList内の指定した番号のものを削除
            bulletList.RemoveAt(0);
        }
    }
}
