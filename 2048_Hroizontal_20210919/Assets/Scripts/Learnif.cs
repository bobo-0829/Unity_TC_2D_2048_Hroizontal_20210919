using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool openDoor;
    public int score = 99;

    // �}�l
    private void Start()
    {
        // �P�_�� if
        //�y�k
        //�p�G(���L��) { ���L�� ���� True �|���� �{�����e }
        //�_�h { ���L�� ���� false �|���� �{�����e }
        if (true)
        {
            print("���L�� true");
        }
        if (false)
        {
            print("���L�� false");
        }

        //openDoor == true �P openDoor
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
    }

    // ��s : �@���������Q�� 60FPS
    private void Update()
    {
        //�p�G���� >=60 �� �ή�
        if (score >= 60)
        {
            print("�ή�");
        }
        //�p�G���� >= 40�� �ɦ�
        //�y�k : else if (���L��) { ���L�� �� true �ɰ��� }
        //else if ��b if �U��P else �W��A�i�L����
        else if(score >= 40)
        {
            print("�ɦ�");
        }
        // �p�G���� < 40 �� ����
        else
        {
            print("����");
        }
    }
}
