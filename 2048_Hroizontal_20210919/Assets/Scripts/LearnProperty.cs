
using UnityEngine;

public class    LearnProperty : MonoBehaviour
{
    #region ���
    public int passwordFiled = 123456789;
    #endregion

    #region �ݩ� Property
    //�ݩ�    Property
    //�y�k
    //�׹��� ������� �ݩʦW��{ �s���l }
    //�۰ʹ�@
    public int passwordProperty { get; set; }
    #endregion

    #region get ���o
    public int myPasswordProperty { get =>999; }
    //get ���o
    //set �]�w
    // ��Ū�ݩ� �u����o
    //=> �H�ڹF Lambda c# 6.0����
    #endregion

    #region ��Ū����g�k
    //��Ū����g�k
    //get �ݭn�ϥ�����r return �Ǧ^
    public string nameCharacter

    {
        get 
        {
            print("�ڦb�ݩ� name Character �̭�~");
            return "Bobo";//return�Ǧ^
        }
    }
    #endregion

    #region �߼g����g�k
    //�߼g����g�k
    //get �ݭn�ϥ�����r value �Ǧ^
    public float attack
    {
        set 
        {
            print("�����O :" + value);
        }
    }
    #endregion


    //�}�l�ƥ�:����ɰ���@��
    private void Start()
    {
        #region Set���
        //�s�� Set �ݩʸ��
        //�y�k :
        //�ݩʦW�� ���w ��;
        passwordProperty = 777;
        #endregion

        #region Get �ݩʸ��
        //���o Get �ݩʸ��
        //�y�k :
        //�ݩʦW��
        print("�ݩʱK�X : " + passwordProperty);
        #endregion

        ///myPasswordProperty = 999;//����]�w ��Ū�ݩ�(�u��get)
        print("�ڪ��ݩʱK�X :" + myPasswordProperty);//get���o�sĶ

        print(nameCharacter);//��Ū����g�k�sĶ

        //print(attack);            //������o �߼g�ݩ�
        attack = 99.9f;             //�߼g����g�k
    }
}
