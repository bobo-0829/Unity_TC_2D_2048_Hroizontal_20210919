
using UnityEngine;

public class    LearnProperty : MonoBehaviour
{
    //欄位
    public int passwordFiled = 123456789;

    //屬性    Property
    //語法
    //修飾詞 資料類型 屬性名稱{ 存取子 }
    public int passwordProperty { get; set; }
    //get 取得
    //set 設定
    
    public int myPasswordProperty { get =>999; }
    // 唯讀屬性 只能取得
    //=> 黏巴達 Lambda c# 6.0版本

    //開始事件:播放時執行一次
    private void Start()
    {
        //存放 Set 屬性資料
        //語法 :
        //屬性名稱 指定 值;
        passwordProperty = 777;
        //取得 Get 屬性資料
        //語法 :
        //屬性名稱
        print("屬性密碼 : " + passwordProperty);

        ///myPasswordProperty = 999;//不能設定 唯讀屬性(只有get)
        print("我的屬性密碼 :" + myPasswordProperty);
    }
}
