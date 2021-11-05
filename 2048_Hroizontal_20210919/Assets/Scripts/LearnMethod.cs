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
    }
#endregion
}
