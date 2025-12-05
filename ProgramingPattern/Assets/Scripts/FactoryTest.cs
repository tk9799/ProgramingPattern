using UnityEngine;
using UnityEngine.InputSystem.iOS;

/// <summary>
/// ファクトリーテストクラス
/// </summary>
public class FactoryTest : MonoBehaviour
{
    [Header("エネミーファクトリー")]
    [SerializeField] private EnemyFactory enemyFactory = null;

    //座標移動用オフセット
    private float positionOffset = 0.0f;

    /// <summary>
    /// ファクトリーテストクラス
    /// </summary>
    void Update()
    {
        //Zキーを押したときに丸形エネミーを生成する
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject enemy = enemyFactory.CreateEnemy(EnemyKind.Sphere);

            //１つ前に生成したオブジェクトと座標が被らないようにするために位置を変える
            SetEnemyPosition(enemy);
        }
        //Xキーを押したときに直方体エネミーを生成する
        else if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject enemy = enemyFactory.CreateEnemy(EnemyKind.Cube);

            //１つ前に生成したオブジェクトと座標が被らないようにするために位置を変える
            SetEnemyPosition(enemy);
        }
        //Cキーを押したときにカプセル型エネミーを生成する
        else if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject enemy = enemyFactory.CreateEnemy(EnemyKind.Capsule);

            //１つ前に生成したオブジェクトと座標が被らないようにするために位置を変える
            SetEnemyPosition(enemy);
        }
    }

    /// <summary>
    /// エネミーを少しずらした位置に配置する
    /// </summary>
    private void SetEnemyPosition(GameObject enemy)
    {
        //座標を更新するためにVector3を新たに作る
        enemy.transform.position = new Vector3(positionOffset, 0.0f, 0.0f);

        //数値を加算して座標を更新する
        positionOffset += 1.0f;
    }
}
