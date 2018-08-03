using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class CountingDown : MonoBehaviour
{
    public int TotalTime = 301;//time given for each level
    public GameObject TimeDisplay;//the apparence of time
    public int CalculatingTime;
    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject CamFollow;//second camera
    public GameObject ThePlayer;
    public int KeepZero;
    public static int TimeLeft;

    void Update()
    {
        TimeLeft = TotalTime;
        if (KeepZero == 0)
        {
            TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "" + TotalTime; //show the time
        }

        if (CalculatingTime == 0)
        {
            StartCoroutine(DeductTime());
        }

        if (TotalTime == 0)
        {
            StartCoroutine(TimeUp());
        }
    }

    IEnumerator DeductTime()
    {
        CalculatingTime = 1;
        TotalTime -= 1;
        yield return new WaitForSeconds(1);
        CalculatingTime = 0;
    }

    IEnumerator TimeUp()
    {
        TotalTime -= 1;
        KeepZero = 1;
        TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "0";
        GlobalLives.LivesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        CamFollow.GetComponent <cameraFollow > ().enabled = false;
        ThePlayer.GetComponent < ThirdPersonUserControl> ().enabled = false;
        ThePlayer.GetComponent < ThirdPersonCharacter > ().enabled = false;
        ThePlayer.GetComponent <CapsuleCollider > ().enabled = false;
        yield return new WaitForSeconds(3);
        GlobalScore.CurrentScore = 0;
        SceneManager.LoadScene(4);
    }
}