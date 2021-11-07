
using UnityEngine;

/// <summary>
///  學習非靜態屬性
/// </summary>
public class LearnPropertyNonStatic : MonoBehaviour
{
    //靜態與非靜態差異 :
    //1. 定義欄位
    //2. 欄位資料與類別相同
    //3. 欄位要儲存資料
    public Camera cam;

    private void Start()
    {
        //靜態對照組
        print("攝影機數量 : " + Camera.allCamerasCount);

        //非靜態屬性
        //取得非靜態屬性語法 :
        //欄位名稱.非靜態屬性名稱
        print("攝影機深度 :" + cam.depth);

    }
}
