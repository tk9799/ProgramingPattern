using UnityEngine;

//敵の種類
//列挙型
//文字列を数値に変換して０から数値を割り振る機能
//enumはどの数値からでも割り振りができるので初期値として０を宣言する
public enum EnemyKind : int
{
    [Tooltip("丸形オブジェクト")]Sphere=0,
    [Tooltip("立方体オブジェクト")]Cube,
    [Tooltip("カプセルオブジェクト")]Capsule,
}

/// <summary>
/// 敵生成ファクトリー
/// </summary>
public class EnemyFactory : MonoBehaviour
{
    [Header("丸形エネミープレハブ")]
    [SerializeField] private GameObject sphereEnemy = null;

    [Header("立方体エネミープレハブ")]
    [SerializeField] private GameObject cubeEnemy = null;

    [Header("カプセル型エネミープレハブ")]
    [SerializeField] private GameObject capsuleEnemy = null;

    //publicメソッドは1つだけにする
    /// <summary>
    /// エネミー生成のアクセサ
    /// </summary>
    public GameObject CreateEnemy(EnemyKind kind)
    {
        //返却用インスタンス
        GameObject enemyInstance = null;

        //エネミー別生成メソッドに切り替え
        switch (kind)
        {
            //１つずつ切り分けて処理を書く
            //オブジェクトの種類を指定したとき、その指定したオブジェクトを生成する
            case EnemyKind.Sphere: enemyInstance = CreateSphereEnemy(); break;
            case EnemyKind.Cube: enemyInstance=CreateCubeEnemy(); break;
            case EnemyKind.Capsule: enemyInstance=CreateCapsuleEnemy(); break;

            //上記以外の場合elseと同じ機能を持つdefaultを使う
            default:
                Debug.LogError("想定されていないタイプの生成エネミーの種類が渡されました");
                break;
        }

        //指定したオブジェクトのインスタンスを返却する
        return enemyInstance;
    }

    /// <summary>
    /// 丸形エネミー生成
    /// </summary>
    private GameObject CreateSphereEnemy()
    {
        return Instantiate(sphereEnemy);
    }

    /// <summary>
    /// 立方体エネミー生成
    /// </summary>
    private GameObject CreateCubeEnemy()
    {
        return Instantiate(cubeEnemy);
    }

    /// <summary>
    /// カプセル型エネミー生成
    /// </summary>
    private GameObject CreateCapsuleEnemy()
    {
        return Instantiate(capsuleEnemy);
    }
}
