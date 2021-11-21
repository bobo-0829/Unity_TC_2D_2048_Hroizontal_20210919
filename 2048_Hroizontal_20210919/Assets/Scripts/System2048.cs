
using UnityEngine;

/// <summary>
/// 2048系統
/// 儲存每個區塊資料
/// 管理隨機生成
/// 滑動控制
/// 數字合併判定
/// 遊戲機制判定
/// </summary>
public class System2048 : MonoBehaviour
{
    /// <summary>
    /// 所有區塊
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];

    private void Start()
    {
        Initialized();
    }

    /// <summary>
    /// 初始化資料
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
/// 區塊資料
/// 每個區塊遊戲製作、座標、編號、數字
/// </summary>
public class BlockData
{
    /// <summary>
    /// 區塊內的數字物件
    /// </summary>
    public GameObject goBlock;
    ///<summary>
    ///區塊座標
    ///</summary>
    public Vector2 v2Position;
    /// <summary>
    /// 區塊編號:二維陣列內的編號
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// 區塊數字 : 預設維0，或者2、4、6、8.......2048
    /// </summary>
    public int number;
}
