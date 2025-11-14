using UnityEngine;

/// <summary>
/// ゲーム管理クラス
/// </summary>
public class GameManager : SingletonMonoBehavior<GameManager>
{
    [Header("テスト用変数")]
    public int testNumber = 0;

    /// <summary>
    /// testNumberの数を表示させるメソッド
    /// </summary>
    public void OutputTestDebugLog()
    {
        Debug.Log($"現在設定されているテスト変数:{testNumber}");
    }
}
