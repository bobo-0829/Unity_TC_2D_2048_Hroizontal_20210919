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
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1,2,3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    //���� KeyCode
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;

    //�C������ GameObject �������w�w�]��
    public GameObject carBox;
    public GameObject carOil;
    //���� component  �������w�w�]��
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;

    #endregion
    #region �s������� Set Get

    //�{���J�f : �ƥ�
    //�}�l�ƥ� : ����C���ɰ���@�� , ��l�]�w
    private void Start()
    {
        print("���o , �U�w :D");

        //���o Get ����� *�w�]�ȥH�ݩʭ��O���D(Inspector)
        //�y�k:
        //���W��
        print("cc �� :" + cc);
        print(weight);

        //�s�� Set �����
        brand = "BMW";
    }
    #endregion
}
