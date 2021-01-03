using UnityEngine;
using UnityEngine.SceneManagement;

public class scanecontrol : MonoBehaviour
{
    [Header("音效來源")]
    public AudioSource aud;
    [Header("按鈕音效")]
    public AudioClip soundclip;
    // Start is called before the first frame update
    
    public void Startgame ()
    {
        aud.PlayOneShot(soundclip);
        Invoke("DelayStartgame", 2f);
    }
    public void DelayStartgame()
    {
        aud.PlayOneShot(soundclip);
        SceneManager.LoadScene("遊戲場景");
    }

    public void backtomenu()
    {
        aud.PlayOneShot(soundclip);
        Invoke("Delaybacktomenu", 1f);
    }

    public void Delaybacktomenu()
    {
        SceneManager.LoadScene("主選單_background");
    }
    public void Quitgame()
    {
        //離開
        Application.Quit();
    }
    
}
