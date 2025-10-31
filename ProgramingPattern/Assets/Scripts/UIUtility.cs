using UnityEngine;

// �A�^�b�`����K�v���Ȃ�����MonoBehaviour�̌p���͂��Ȃ�
public static class UIUtility
{
    /// <summary>
    /// 3�����ƂɁu,�v��}������������𐶐�����
    /// static�����邱�ƂŃN���X���ƕϐ�������ƌĂяo�����Ƃ��ł���
    /// MonoBehaviour���p������Ă��Ȃ�����static���Ȃ��ƃG���[���o��
    /// static�͍ŏ����炠�镨����static�ɃA�N�Z�X�����Ƃ��ɐ��������(�ŏ��͌����ɂ͖���)
    /// </summary>
    public static string NumberFormatter(int number)
    {
        //ToString�͐��l�𕶎���ɕϊ����邱�Ƃ��ł���
        //�R�����ƂɃJ���}�ŋ�؂�
        return number.ToString("#,0");
    }

    /// <summary>
    /// ���l���p�[�Z���g�\���ɕύX�i������Q�ʂ܂Łj
    /// static�����邱�ƂŃN���X���ƕϐ�������ƌĂяo�����Ƃ��ł���
    /// MonoBehaviour���p������Ă��Ȃ�����static���Ȃ��ƃG���[���o��
    /// </summary>
    public static string ConvertPercent(float ratio)
    {
        //ratio�̐��l���p�[�Z���g�\�����邽��100�Ŋ���
        float convertRatio = ratio * 100.0f;

        //"F"�̎��ɐ������̐���\�����Ă����艺�͎l�̌ܓ������こ��\������
        return convertRatio.ToString("F2") + "%";
    }
}
