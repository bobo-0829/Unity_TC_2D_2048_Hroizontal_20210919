using UnityEngine;


/// <summary>
///  �����t��:���Z��
///  �~�� : �n�~�Ӫ����O(�����O)
///  �֦������O������ �F ���B�ݩʡB��k�B�ƥ�
/// </summary>
public class AttackSystemFar : AttackSystem
{
    [Header("�ͦ��ɤl��m")]
    public Transform positionSpawn;
    [Header("�����ɤl")]
    public GameObject goAttackParticle;
    [Header("�ɤl�o�g�t��"), Range(0, 1500)]
    public float speed = 500;

    //override �Ƽg : �Ƽg�����O virtual ����
    public override void Attack(float increase = 0)
    {
        //base.Attack();      // base �� : �����O�����e

        onAttackStart.Invoke();

        // print("���Z����");

        // �ͦ�(����A�y�СA����)
        // �ͦ�������W�٫��|��(clone)
        // Quaternion �|����
        // identity �s����
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        // �K�[����<�l�u�t��>().�����O = �������t�Χ����O
        tempAttack.AddComponent<Bullet>().attack = attack + increase;

        print("���������O" +(attack + increase));
    }
}