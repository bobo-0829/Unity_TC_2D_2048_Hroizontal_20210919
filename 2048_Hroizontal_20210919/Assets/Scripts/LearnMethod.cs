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
    //�Ѽ� : ������� �ѼƦW�� (���w �w�]��)
    //�Ѽ�1�A�Ѽ�2�A.....�A�Ѽ�n
    public void Drive(int speed,string sound = "������")
    {
        print("�}���A�ɳt :" + speed);
        print("���� : " + sound);
    }
    #endregion
}
