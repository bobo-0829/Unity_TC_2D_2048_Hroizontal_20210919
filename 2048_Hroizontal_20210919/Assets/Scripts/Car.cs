//註解:說明文字,不備執行@#
//功能 2021.10.17
//開發者 BOBO 2021.10.17
using UnityEngine;//引用 Uunity Engine API

public class Car : MonoBehaviour    
//class類別(藍圖)名稱要跟檔名相同,大小寫也要相同
{
    #region 欄位語法與四大基本類型
    //認識欄位 Field ,儲存資料
    //語法:
    //修飾詞 資料類型 欄位名稱 指定 預設值 結束符號
    //常用四大資料類型
    //整數     沒有小數點的正負整數 int     預設值0
    //浮點數   有小數點得正負整數   float   預設值0
    //字串     文字資訊   string          預設值空
    //布林值   是與否     true/false  bool    預設值false
    //修飾詞:
    //私人 僅限此類別存取 unity 不顯示 private(預設)
    //公開 所有類別可存取 unity 會顯示 public

    //欄位屬性 Attritube
    //語法:
    //[屬性名稱(值)] - 必須放在欄位前面或上一方
    //1.標題 Header (字串)
    //2.提示 Tooltip (字串)
    //3.範圍 Range (浮點數,浮點數)
    [Header("汽車的cc數")][Range(1000, 5000)]
    public int cc = 2000;
    [Tooltip("這是汽車的重量 , 範圍是 3 ~ 20"), Range(3, 20)]
    public float weight = 3.5f;
    public string brand = "賓士";
    public bool hasSkyWindow = true;
    #endregion
    #region 遊戲常用資料類型
    //顏色 color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpge = new Color(0, 1, 0, 0.3f);
    //座標 Vector
    //Vecter 2 - 4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1,2,3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    //按鍵 KeyCode
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;

    //遊戲物件 GameObject 不須指定預設值
    public GameObject carBox;
    public GameObject carOil;
    //元件 component  不須指定預設值
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;

    #endregion
    #region 存取欄位資料 Set Get

    //程式入口 : 事件
    //開始事件 : 播放遊戲時執行一次 , 初始設定
    private void Start()
    {
        print("哈囉 , 沃德 :D");

        //取得 Get 欄位資料 *預設值以屬性面板為主(Inspector)
        //語法:
        //欄位名稱
        print("cc 數 :" + cc);
        print(weight);

        //存放 Set 欄位資料
        brand = "BMW";
    }
    #endregion
}
