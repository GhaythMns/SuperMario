using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class level02_death : MonoBehaviour
{
    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject CamFollow;
    public GameObject ThePlayer;

    IEnumerator OnTriggerEnter(Collider col)
    {
        GlobalLives.LivesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        CamFollow.GetComponent<cameraFollow>().enabled = false;
        ThePlayer.GetComponent<ThirdPersonUserControl>().enabled = false;//stop the script of player
        ThePlayer.GetComponent<ThirdPersonCharacter>().enabled = false;
        ThePlayer.transform.localScale -= new Vector3(0.0f, 0.7f, 0.0f);
        ThePlayer.GetComponent<CapsuleCollider>().enabled = false;//remove the payer's collider
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(4);
        yield return new WaitForSeconds(1);
    }
}
