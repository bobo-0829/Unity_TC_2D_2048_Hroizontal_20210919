
using UnityEngine;

public class LearnLoop : MonoBehaviour
{
    
    private void Start()
    {
        //��X�Ʀr1~5
        print("�Ʀr :" + 1);
        print("�Ʀr :" + 2);
        print("�Ʀr :" + 3);
        print("�Ʀr :" + 4);
        print("�Ʀr :" + 5);

        //�j�� :���ư���
        //while �j��y�k :
        //while (���L��) { ���L�� ���� true �|���� ���򪽨쥬�L�Ȭ� false �{�����e }
        int number = 1;

        //��Ʀr �p�� 6 �|����...
        while (number < 6)
        {
            print("while �j��Ʀr :" + number);
            number++;
        }

        for(int i = 1; i < 6; i++)
        {
            print("for �j��Ʀr :" + i);
            
        }

    }
}
