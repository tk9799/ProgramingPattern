using UnityEngine;

public class TestScripts : MonoBehaviour
{
    private void Start()
    {
        int a = 1234567980;

        //TestScripts�N���X�𐶐��������_��UIUtility�͂��łɂ��邽�ߌĂяo�����Ƃ��ł���
        //a��NumberFormatter���\�b�h���ɂ���ToString�ŕ�����^�ɕϊ����Ďw�肵���\��������
        string b = UIUtility.NumberFormatter(a);

        float c = 0.45286f;

        //TestScripts�N���X�𐶐��������_��UIUtility�͂��łɂ��邽�ߌĂяo�����Ƃ��ł���
        //c��ConvertPercent���\�b�h���ɂ���ToString�ŕ�����^�ɕϊ����Ďw�肵���\��������
        string d = UIUtility.ConvertPercent(c);

        Debug.Log($"�R������,����ꂽ����:{b}");
        Debug.Log($"�p�[�Z���g�ɒ���������:{d}");
    }
}
