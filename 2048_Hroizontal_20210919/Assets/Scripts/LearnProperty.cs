
using UnityEngine;

public class    LearnProperty : MonoBehaviour
{
    //���
    public int passwordFiled = 123456789;

    //�ݩ�    Property
    //�y�k
    //�׹��� ������� �ݩʦW��{ �s���l }
    //�۰ʹ�@
    public int passwordProperty { get; set; }
   
    
    public int myPasswordProperty { get =>999; }
    //get ���o
    //set �]�w
    // ��Ū�ݩ� �u����o
    //=> �H�ڹF Lambda c# 6.0����

    public string nameCharacter
    {
        get 
        {
            print("�ڦb�ݩ� name Character �̭�~");
            return "Bobo";//return�Ǧ^
        }
    }


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

        ///myPasswordProperty = 999;//����]�w ��Ū�ݩ�(�u��get)
        print("�ڪ��ݩʱK�X :" + myPasswordProperty);

        print(nameCharacter);
    }
}
