
using UnityEngine;

/// <summary>
///  �ǲ߫D�R�A�ݩ�
/// </summary>
public class LearnPropertyNonStatic : MonoBehaviour
{
    //�R�A�P�D�R�A�t�� :
    //1. �w�q���
    //2. ����ƻP���O�ۦP
    //3. ���n�x�s���
    public Camera cam;

    private void Start()
    {
        //�R�A��Ӳ�
        print("��v���ƶq : " + Camera.allCamerasCount);

        //�D�R�A�ݩ�
        //���o�D�R�A�ݩʻy�k :
        //���W��.�D�R�A�ݩʦW��
        print("��v���`�� :" + cam.depth);

    }
}
