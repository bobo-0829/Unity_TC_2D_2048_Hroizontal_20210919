using UnityEngine;

/// <summary>
///  summmary �K�n
///  ///��ƻ����A��ܦb VS �sĶ�����ܤW
/// </summary>
public class LearnMethod : MonoBehaviour
{
    #region ��k����
    // ��k Method Functuon (�禡)
    // �@�� : ������������{�����e
    // �y�k :
    // �׹��� �Ǧ^������� ��k�W�� ( �Ѽ� ) { �{�����e }
    // �L�Ǧ^ void
    // �R�W�ߺD : Unity ��k�H�j�g�}�Y
    public void Test() 
    {
        print("�ڬO���դ�k~");
    }
    #endregion

#region �I�s��k
    private void Start()
    {
        //�I�s��k
        //��k�W��();
        Test();
        Test();
        Drive90();  //��Ӳ� �g��k
        Drive100(); //��Ӳ� �g��k
        //�I�s��k : �޼�
        //�w�]�ȱo�Ѽƥi�H����g�A�ϥιw�]��
        Drive(70, "�F�F�F");  //speed=70 �ǤJDrive //��z�� �n��k
        Drive(200, "������"); //��z�� �n��k
        Drive(300);
        // �ɳt50�A�w�]�ȡA���Y
        //���w�w�]�ȰѼƻy�k �ѼƦW�� �_�� ��
        Drive(50, effect: "���Y");

        int t = Ten();
        print("�Ǧ^��k :" + t);

        print("���ϥ��ܼ��x�s�Ǧ^��:" + Ten());

        int damage = Damage(90, 30);
        print("90 �����O�P 30 ���m�O���ˮ` :" + damage);
    }
    #endregion
    #region ��Ӳ� �g��k
    // �����ݨD
    // ���񭵮�
    // �T���i�H�[�t�A�ɼƬ� 90
    // �T���i�H�[�t�A�ɼƬ� 100
    public void Drive90()
    {
        print("�}���A�ɳt :" + 90);
        print("���� :");
    }
    public void Drive100()
    {
        print("�}���A�ɳt :" + 100);
        print("���� :");
    }
    #endregion

    #region  �Ѽ� : ������� �ѼƦW�١A�n��k
    //�w�q��k
    //�Ѽ� : ������� �ѼƦW�� (���w �w�]��) *�g�b()�̥k��
    //�Ѽ�1�A�Ѽ�2�A.....�A�Ѽ�n
    public void Drive(int speed,string sound = "������",string effect="�ǹ�")
    {
        print("�}���A�ɳt :" + speed);
        print("���� : " + sound);
        print("�S�� : " + effect);
    }
    #endregion

    #region �Ǧ^������k
    //���Ǧ^������k�����ϥ� return
    public int Ten()
    {
        return 10;
    }
    #endregion

    //�����O - ���m�O = �ˮ`��
    //90 - 30 = 60
    /// <summary>
    /// �p��ˮ`�ȡA�����O-���m�O=�ˮ`��
    /// </summary>
    /// <param name="attack"></param>
    /// <param name="defence"></param>
    /// <returns></returns>
    public int Damage(int attack,int defence)
    {
        return attack - defence;
    }
}