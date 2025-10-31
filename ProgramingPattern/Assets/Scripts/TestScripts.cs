using UnityEngine;

public class TestScripts : MonoBehaviour
{
    private void Start()
    {
        int a = 1234567980;

        //TestScriptsクラスを生成した時点でUIUtilityはすでにあるため呼び出すことができる
        //aをNumberFormatterメソッド内にあるToStringで文字列型に変換して指定した表示をする
        string b = UIUtility.NumberFormatter(a);

        float c = 0.45286f;

        //TestScriptsクラスを生成した時点でUIUtilityはすでにあるため呼び出すことができる
        //cをConvertPercentメソッド内にあるToStringで文字列型に変換して指定した表示をする
        string d = UIUtility.ConvertPercent(c);

        Debug.Log($"３桁ずつ,を入れた数字:{b}");
        Debug.Log($"パーセントに直した数字:{d}");
    }
}
