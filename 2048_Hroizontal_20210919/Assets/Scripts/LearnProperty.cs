
using UnityEngine;

public class    LearnProperty : MonoBehaviour
{
    #region 欄位
    public int passwordFiled = 123456789;
    #endregion

    #region 屬性 Property
    //屬性    Property
    //語法
    //修飾詞 資料類型 屬性名稱{ 存取子 }
    //自動實作
    public int passwordProperty { get; set; }
    #endregion

    #region get 取得
    public int myPasswordProperty { get =>999; }
    //get 取得
    //set 設定
    // 唯讀屬性 只能取得
    //=> 黏巴達 Lambda c# 6.0版本
    #endregion

    #region 唯讀完整寫法
    //唯讀完整寫法
    //get 需要使用關鍵字 return 傳回
    public string nameCharacter

    {
        get 
        {
            print("我在屬性 name Character 裡面~");
            return "Bobo";//return傳回
        }
    }
    #endregion

    #region 唯寫完整寫法
    //唯寫完整寫法
    //get 需要使用關鍵字 value 傳回
    public float attack
    {
        set 
        {
            print("攻擊力 :" + value);
        }
    }
    #endregion


    //開始事件:播放時執行一次
    private void Start()
    {
        #region Set資料
        //存放 Set 屬性資料
        //語法 :
        //屬性名稱 指定 值;
        passwordProperty = 777;
        #endregion

        #region Get 屬性資料
        //取得 Get 屬性資料
        //語法 :
        //屬性名稱
        print("屬性密碼 : " + passwordProperty);
        #endregion

        ///myPasswordProperty = 999;//不能設定 唯讀屬性(只有get)
        print("我的屬性密碼 :" + myPasswordProperty);//get取得編譯

        print(nameCharacter);//唯讀完整寫法編譯

        //print(attack);            //不能取得 唯寫屬性
        attack = 99.9f;             //唯寫完整寫法
    }
}
