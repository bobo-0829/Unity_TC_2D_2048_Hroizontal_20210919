
using UnityEngine;

public class    LearnProperty : MonoBehaviour
{
    //���
    public int passwordFiled = 123456789;

    //�ݩ�    Property
    //�y�k
    //�׹��� ������� �ݩʦW��{ �s���l }
    public int passwordProperty { get; set; }

    //�}�l�ƥ�:����ɰ���@��
    private void Start()
    {
        //�s�� Set �ݩʸ��
        //�y�k :
        //�ݩʦW�� ���w ��;
        passwordProperty = 777;
        //���o Get �ݩʸ��
        //�y�k :
        //�ݩʦW��
        print("�ݩʱK�X : " + passwordProperty);
    }
}
