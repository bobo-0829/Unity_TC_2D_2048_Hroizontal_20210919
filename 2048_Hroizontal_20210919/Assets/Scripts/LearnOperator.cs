
using UnityEngine;

/// <summary>
/// �{�ѹB��l
/// 1.���w
/// 2.�ƾ�
/// 3.���
/// 4.�޿�
/// </summary>

public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;

    private void Start()
    {
        #region ���w�B��l
        //���w = 
        //��������w�B��l�k��b���w������
        #endregion

        #region �ƾǹB��l
        //�[����l
        // + - * / %
        print("�[�k :" + (a + b));    //���G 13
        print("��k :" + (a - b));    //���G 7
        print("���k :" + (a * b));    //���G 30
        print("���k :" + (a / b));    //���G 3.33333
        print("�l�k :" + (a % b));    //���G 1
        #endregion
    }

}
