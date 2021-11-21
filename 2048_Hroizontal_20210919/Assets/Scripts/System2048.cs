
using UnityEngine;

/// <summary>
/// 2048�t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048 : MonoBehaviour
{
    /// <summary>
    /// �Ҧ��϶�
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];

    private void Start()
    {
        Initialized();
    }

    /// <summary>
    /// ��l�Ƹ��
    /// </summary>
    private void Initialized()
    {
        for (int i = 0; i < blocks.GetLongLength(0); i++)
        {
            for (int j = 0;  j < blocks.GetLongLength(1);  j++)
            {
                blocks[i, j] = new BlockData();
            }
        }
    }
}

/// <summary>
/// �϶����
/// �C�Ӱ϶��C���s�@�B�y�СB�s���B�Ʀr
/// </summary>
public class BlockData
{
    /// <summary>
    /// �϶������Ʀr����
    /// </summary>
    public GameObject goBlock;
    ///<summary>
    ///�϶��y��
    ///</summary>
    public Vector2 v2Position;
    /// <summary>
    /// �϶��s��:�G���}�C�����s��
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// �϶��Ʀr : �w�]��0�A�Ϊ�2�B4�B6�B8.......2048
    /// </summary>
    public int number;
}
