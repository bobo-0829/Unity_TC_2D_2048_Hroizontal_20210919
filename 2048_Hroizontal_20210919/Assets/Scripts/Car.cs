//����:������r,���ư���@#
//�\�� 2021.10.17
//�}�o�� BOBO 2021.10.17
using UnityEngine;//�ޥ� Uunity Engine API

public class Car : MonoBehaviour    
//class���O(�Ź�)�W�٭n���ɦW�ۦP,�j�p�g�]�n�ۦP
{
    #region ���y�k�P�|�j������
    //�{����� Field ,�x�s���
    //�y�k:
    //�׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    //�`�Υ|�j�������
    //���     �S���p���I�����t��� int     �w�]��0
    //�B�I��   ���p���I�o���t���   float   �w�]��0
    //�r��     ��r��T   string          �w�]�Ȫ�
    //���L��   �O�P�_     true/false  bool    �w�]��false
    //�׹���:
    //�p�H �ȭ������O�s�� unity ����� private(�w�])
    //���} �Ҧ����O�i�s�� unity �|��� public

    //����ݩ� Attritube
    //�y�k:
    //[�ݩʦW��(��)] - ������b���e���ΤW�@��
    //1.���D Header (�r��)
    //2.���� Tooltip (�r��)
    //3.�d�� Range (�B�I��,�B�I��)
    [Header("�T����cc��")][Range(1000, 5000)]
    public int cc = 2000;
    [Tooltip("�o�O�T�������q , �d��O 3 ~ 20"), Range(3, 20)]
    public float weight = 3.5f;
    public string brand = "���h";
    public bool hasSkyWindow = true;
    #endregion
    #region �C���`�θ������
    //�C�� color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpge = new Color(0, 1, 0, 0.3f);
    //�y�� Vector
    //Vecter 2 - 4
    public Vector2 v2;
    #endregion
}
