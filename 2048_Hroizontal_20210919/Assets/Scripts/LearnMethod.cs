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
    }
#endregion
}
