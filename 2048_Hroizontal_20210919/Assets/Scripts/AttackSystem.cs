
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;   //�ޥ� �t�� ���X API : ��P�{�� Coroutine


public class AttackSystem : MonoBehaviour
{
    #region ���:���}
    [Header("�����O��")]
    public float attack = 10;
    [Header("�����ؼ�")]
    public GameObject goTarget;
    [Header("�����O����")]
    public Text textAttack;
    [Header("�������"), Range(0, 10)]
    public float delayAttack = 3.5f;
    [Header("����ǰe�ˮ`"), Range(0, 5)]
    public float delaySendDamage = 0.5f;
    [Header("�ʵe�Ѽ�")]
    public string parameterAttack = "����Ĳ�o";

    #endregion

    #region ��� : �O�@ Protected
    // public ���\�������O�s��
    // private ���\�����O�s��
    // protected ���\�l���O�s��
    protected HealthSystem targetHealthSystem;
    protected Animator ani;
    #endregion

    #region �ƥ�
    private void Awake()
    {
        textAttack.text = "ATK " + attack;
        ani = GetComponent<Animator>();
        targetHealthSystem = goTarget.GetComponent<HealthSystem>();
    }
    #endregion

    [Header("�����}�l�ƥ�")]
    public UnityEvent onAttackStart; 
    [Header("���������ƥ�")]
    public UnityEvent onAttackFinish;

    private bool isStop;

    /// <summary>
    /// �������
    /// </summary>
    public void StopAttack()
    {
        isStop = true;              // �w�g����    
        StopAllCoroutines();        // ����Ҧ���{
        enabled = false;            // �����}��
    }

    #region ��k:���}

    //virtual ���� : ���\�l���O�Ƽg
    ///<summary>
    ///������k
    ///</summary>
    public virtual void Attack(float increase = 0)
    {
        if (isStop) return;     //�p�G ���� �N���X

        //�Ұ� ��P�{��
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        //���� 3.5 ��
        yield return new WaitForSeconds(delayAttack);

       
        //�����ʵe
        ani.SetTrigger(parameterAttack);
        //���� 0.5 ��
        yield return new WaitForSeconds(delaySendDamage);

        onAttackStart.Invoke();
        //�ǰe�ˮ`
        targetHealthSystem.Hurt(attack);
        onAttackFinish.Invoke();
    }
    #endregion
}