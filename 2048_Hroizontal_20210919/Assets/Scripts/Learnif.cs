using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool openDoor;

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
}
