using UnityEngine;

/// <summary>
///  學習靜態方法
/// </summary>
public class LearnMethodStatic : MonoBehaviour
{
    private void Start()
    {
        //靜態方法
        //呼叫靜態方法語法 :
        //類別名稱.靜態方法名稱(對應的引數) :
        float r = Random.Range(3.5f, 7.5f);
        print("隨機範圍 3.5 ~ 7.5" + r);
    }
}
