using UnityEngine;

// アタッチする必要がないためMonoBehaviourの継承はしない
public static class UIUtility
{
    /// <summary>
    /// 3桁ごとに「,」を挿入した文字列を生成する
    /// staticがあることでクラス名と変数を入れると呼び出すことができる
    /// MonoBehaviourが継承されていないためstaticがないとエラーが出る
    /// staticは最初からある物だがstaticにアクセスしたときに生成される(最初は厳密には無い)
    /// </summary>
    public static string NumberFormatter(int number)
    {
        //ToStringは数値を文字列に変換することができる
        //３桁ごとにカンマで区切る
        return number.ToString("#,0");
    }

    /// <summary>
    /// 数値をパーセント表示に変更（小数第２位まで）
    /// staticがあることでクラス名と変数を入れると呼び出すことができる
    /// MonoBehaviourが継承されていないためstaticがないとエラーが出る
    /// </summary>
    public static string ConvertPercent(float ratio)
    {
        //ratioの数値をパーセント表示するため100で割る
        float convertRatio = ratio * 100.0f;

        //"F"の次に数字分の数を表示してそれより下は四捨五入した後％を表示する
        return convertRatio.ToString("F2") + "%";
    }
}
