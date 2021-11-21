using UnityEngine;
using System.Linq;

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
    [Header("�ťհ϶�")]
    public Transform[] blocksEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e��2048")]
    public Transform traCanvas2048;

    // �p�H������
    [SerializeField]
    private Direction direction;

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
            for (int j = 0; j < blocks.GetLongLength(1); j++)
            {
                blocks[i, j] = new BlockData();
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = blocksEmpty[i * blocks.GetLongLength(1) + j].position;
            }
        }
        PrintBlockData();
        CreateRandomNumberBlock();
        CreateRandomNumberBlock();
    }

    /// <summary>
    /// ��X�϶��G���}�C���
    /// </summary>
    private void PrintBlockData()
    {
        string result = "";
        for (int i = 0; i < blocks.GetLongLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLongLength(1); j++)
            {
                result += "�s��" + blocks[i, j].v2Index + ")" + "<color=red> �Ʀr : " + blocks[i, j].number + "</color><color=yellow>" + blocks[i,j].goBlock+ "</color> |";
            }
            result += "\n";
        }
        print(result);
    }

    /// <summary>
    /// �إ��H���Ʀr�϶�
    /// �P�_�Ҧ��϶������S���Ʀr�A�Ʀr��0
    /// �H���D��@��
    /// �ͦ��Ʀr���Ӱ϶���
    /// </summary>
    private void CreateRandomNumberBlock()
    {
        var equalZero =
            from BlockData data in blocks
            where data.number == 0
            select data;

        print("���s����Ʀ��X��" + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("�H���s�� : " + randomIndex);

        //��X�H���϶� �s��
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[equalZero.ToArray()[randomIndex].v2Index.x, equalZero.ToArray()[randomIndex].v2Index.y];
        //�N�Ʀr 2  ��J���H���϶���
        dataRandom.number = 2;

        PrintBlockData();
        //��Ҥ�-�ͦ�(����A������)
        GameObject tempBlock =  Instantiate(goNumberBlock, traCanvas2048);
        //�ͦ��϶� ���w�y��
        tempBlock.transform.position = dataRandom.v2Position;
        //�x�s �ͦ��϶��@���
        dataRandom.goBlock = tempBlock;
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
///<summary>
/// ��V�C�| :�L�B�k�B���B�W�B�U
///</summary>
public enum Direction
{
    None ,Right ,Left ,Up ,Down
}


