using UnityEngine;

/// <summary>
/// シングルトン確認用スクリプト
/// </summary>
public class GameTest : MonoBehaviour
{
    /// <summary>
    /// 更新
    /// </summary>
    void Update()
    {
        //Aキーを押したとき
        if (Input.GetKeyDown(KeyCode.A))
        {
            //GameManagerスクリプトのOutputTestDebugLog()メソッドを呼び出す
            GameManager.Instance.OutputTestDebugLog();
        }

        //Sキーを押したとき
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Instanceの子クラス（GameManager）にあるtestNumberを呼び出して加算する
            //testNumberを加算
            GameManager.Instance.testNumber++;
        }
    }
}
