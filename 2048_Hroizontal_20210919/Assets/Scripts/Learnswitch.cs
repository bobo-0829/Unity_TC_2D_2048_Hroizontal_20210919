using UnityEngine;

/// <summary>
///  �P�_�� switch
/// </summary>
public class Learnswitch : MonoBehaviour
{
    public string equipment;
    private void Start()
    {
        
        //switch �y�k :
        //switch (�n�P�_�����)
        // {
        //      case �� 1:
        //              �{�����e
        //              break;
        //      case �� 2:
        //              �{�����e
        //              break;
        //      default :               //���Ƥ��ŦX�W�� case
        //              �{�����e
        //              break;
        // }

        switch (equipment)
        {
            case "�M�l":
                print("�A�{�b���ۤM�l");
                break;
            case "�e�l":
                print("�A�{�b���ۤe�l");
                break;
            default:
                print("�A�������O�Z�� -.-");
                break;
        }



    }



}
