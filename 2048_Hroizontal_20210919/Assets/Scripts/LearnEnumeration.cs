using UnityEngine;

/// <summary>
/// �C�| : �U�Ԧ����
/// </summary>
public class LearnEnumeration : MonoBehaviour
{
    //1.�w�q�C�|
    //�y�k : �׹��� �C�| �C�|�W��{�C�|��1�A�C�|��2�A....�C�|��n}
    public enum StateEnemy
    {
        Idle, walk, Track, Attack, Dead
    }
    public StateEnemy state;

    private void Update()
    {
        switch (state)//state Tab����U�Acase�N�|���X��
        {
            case StateEnemy.Idle:
                print("���ݤ�");
                break;
            case StateEnemy.walk:
                print("������");
                break;
            case StateEnemy.Track:
                print("�l�ܤ�");
                break;
            case StateEnemy.Attack:
                print("������");
                break;
            case StateEnemy.Dead:
                print("���`��");
                break;
            default:
                break;
        }
    }

}
