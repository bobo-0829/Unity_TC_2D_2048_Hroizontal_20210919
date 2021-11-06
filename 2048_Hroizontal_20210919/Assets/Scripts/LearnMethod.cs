using UnityEngine;

/// <summary>
///  summmary 摘要
///  ///資料說明，顯示在 VS 編譯器提示上
/// </summary>
public class LearnMethod : MonoBehaviour
{
    #region 方法測試
    // 方法 Method Functuon (函式)
    // 作用 : 執行較複雜的程式內容
    // 語法 :
    // 修飾詞 傳回資料類型 方法名稱 ( 參數 ) { 程式內容 }
    // 無傳回 void
    // 命名習慣 : Unity 方法以大寫開頭
    public void Test() 
    {
        print("我是測試方法~");
    }
    #endregion

#region 呼叫方法
    private void Start()
    {
        //呼叫方法
        //方法名稱();
        Test();
        Test();
        Drive90();  //對照組 土方法
        Drive100(); //對照組 土方法
        //呼叫方法 : 引數
        //預設值得參數可以不填寫，使用預設值
        Drive(70, "轟轟轟");  //speed=70 傳入Drive //整理組 好方法
        Drive(200, "咻咻咻"); //整理組 好方法
        Drive(300);
        // 時速50，預設值，石頭
        //指定預設值參數語法 參數名稱 冒號 值
        Drive(50, effect: "石頭");

        int t = Ten();
        print("傳回方法 :" + t);

        print("不使用變數儲存傳回值:" + Ten());

        int damage = Damage(90, 30);
        print("90 攻擊力與 30 防禦力的傷害 :" + damage);
    }
    #endregion
    #region 對照組 土方法
    // 企劃需求
    // 播放音效
    // 汽車可以加速，時數為 90
    // 汽車可以加速，時數為 100
    public void Drive90()
    {
        print("開車，時速 :" + 90);
        print("音效 :");
    }
    public void Drive100()
    {
        print("開車，時速 :" + 100);
        print("音效 :");
    }
    #endregion

    #region  參數 : 資料類型 參數名稱，好方法
    //定義方法
    //參數 : 資料類型 參數名稱 (指定 預設值) *寫在()最右邊
    //參數1，參數2，.....，參數n
    public void Drive(int speed,string sound = "咻咻咻",string effect="灰塵")
    {
        print("開車，時速 :" + speed);
        print("音效 : " + sound);
        print("特效 : " + effect);
    }
    #endregion

    #region 傳回類型方法
    //有傳回類型方法必須使用 return
    public int Ten()
    {
        return 10;
    }
    #endregion

    //攻擊力 - 防禦力 = 傷害值
    //90 - 30 = 60
    /// <summary>
    /// 計算傷害值，攻擊力-防禦力=傷害值
    /// </summary>
    /// <param name="attack"></param>
    /// <param name="defence"></param>
    /// <returns></returns>
    public int Damage(int attack,int defence)
    {
        return attack - defence;
    }
}
