using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool openDoor;
    public int score = 99;

    // 開始
    private void Start()
    {
        // 判斷式 if
        //語法
        //如果(布林值) { 當布林值 等於 True 會執行 程式內容 }
        //否則 { 當布林值 等於 false 會執行 程式內容 }
        if (true)
        {
            print("布林值 true");
        }
        if (false)
        {
            print("布林值 false");
        }

        //openDoor == true 與 openDoor
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }

    // 跟新 : 一秒執行約六十次 60FPS
    private void Update()
    {
        //如果分數 >=60 分 及格
        if (score >= 60)
        {
            print("及格");
        }
        //如果分數 >= 40分 補考
        //語法 : else if (布林值) { 布林值 為 true 時執行 }
        //else if 放在 if 下方與 else 上方，可無限個
        else if(score >= 40)
        {
            print("補考");
        }
        // 如果分數 < 40 分 死當
        else
        {
            print("死當");
        }
    }
}
