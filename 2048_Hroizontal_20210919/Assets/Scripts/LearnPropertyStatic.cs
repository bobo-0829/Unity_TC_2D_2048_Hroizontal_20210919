
using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{

    private void Start()
    {
        //�R�A�ݩ�  Static Property
        //���o�R�A�ݩ�
        //�y�k : ���O�ݩ�.�R�A�ݩʦW��
        print("�H���� : " + Random.value);
        print("��v���`�� : " + Camera.allCamerasCount);

        //�]�w�R�A�ݩ�
        //�y�k : ���O�W��.�R�A�ݩʦW�� ���w ��;
        Cursor.visible = false;
        //Mathf.PI = 9.9999f;  //(Read Only) ���i��� ��Ū�ݩ�

    }
}
