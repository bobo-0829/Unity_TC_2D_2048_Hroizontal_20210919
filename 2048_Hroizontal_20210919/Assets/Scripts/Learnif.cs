using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool openDoor;

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
}
