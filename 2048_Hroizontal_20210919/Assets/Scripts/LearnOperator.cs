
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
    public int c = 30;
    public int hp = 100;

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

        c = c + 1;//�쥻�g�k
        print("c ���G :" + c);
        c++;                         //���W ++ ; ���� --
        print("c ���G :" + c);

        hp = hp + 10;
        print("hp ���G :" + hp);
        hp += 10;                   // �A�μƾǹB��l +=  -=  *=  /=  %=
        print("hp ���G :" + hp);
        #endregion

        #region ����B��l
        //�j�� �p�� �j���� �p���� ���� ������
        //  <   >    >=     <=   ==   !=
        // �����ӭȡA�ño�쥬�L�ȵ��G

        print("a > b " + (a > b));   // t
        print("a < b " + (a < b));   // f
        print("a >= b " + (a >= b));   // t
        print("a <= b " + (a <= b));   // f
        print("a == b " + (a == b));   // f
        print("a != b " + (a != b));   // t
        #endregion

        #region �޿�B��l
        // �åB�B�Ϊ̡B�A��
        // &&  || !
        //�åB�B�Ϊ�
        // �����ӥ��L�ȡA�ño�쥬�L�ȵ��G
        print("t && t " + (true && true));   //t
        print("f && t " + (false && true));  //f
        print("t && f " + (true && false));  //f
        print("f && f " + (false && false)); //f
         // �Ϊ� : �u�n���@�� t ���G�N�O t
        print(" t || t " + (true || true));   //t
        print(" f || t " + (false || true));  //t
        print(" t || f " + (true || false));  //t
        print(" f || f " + (false || false)); //f
        //Alt + Shift + > �ֳt���
        #endregion
    }

}
