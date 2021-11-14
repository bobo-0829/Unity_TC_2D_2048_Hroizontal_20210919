using UnityEngine.SceneManagement;//���J�禡�w
using UnityEngine;
using UnityEngine.Audio;
/// <summary>
/// �}�l�e�����޲z��
/// �}�l�C�� �]�w ���}�C��
/// </summary>
public class MenuManager : MonoBehaviour
{
    // unity ���s�P�������q
    // 1.���}����k
    // 2.���s�]�w�I���ƥ� on click

    public AudioMixer mixer;
    public AudioMixer mixerSFX;

    ///<summary>
    /// �}�l�C��
    /// </summary>
    public void StartGame()
    {
        // �����޲z.���J����(�����W��)
        SceneManager.LoadScene("�C������");//���J�C������
        //SceneManager.LoadScene(1);
    }

    ///<summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGameBGM(float volume)
    {
        print("BGM �Ʊ쭵�q"+volume);
        mixer.SetFloat("���qBGM", volume);

    }
    public void SettingGameSFX(float volume)
    {
        print("SFX �Ʊ쭵�q" + volume);
        mixer.SetFloat("����SFX", volume);

    }
    ///<summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
       // ���ε{��.���}();
       // Quit ���|�A Editor ����A�o�������� ����BPC
        Application.Quit();

        print("���}�C��~");
    }
}
