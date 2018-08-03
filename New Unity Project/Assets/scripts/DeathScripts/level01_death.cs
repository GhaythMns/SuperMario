using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class level01_death : MonoBehaviour
{
    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject CamFollow;
    public GameObject ThePlayer;

    IEnumerator OnTriggerEnter(Collider col)
    {
        GlobalLives.LivesAmount -= 1; // pour chaque accident on perd un Live
        LevelMusic.SetActive(false); //atteindre la sonnerie normal     
        DeathSound.Play(); // mis en marche la sonnerie de mort
        CamFollow.GetComponent<cameraFollow>().enabled = false; //arreter la camera de suivre le joueur apres sa mort
        ThePlayer.GetComponent<ThirdPersonUserControl>().enabled = false;//stop the script of player
        ThePlayer.GetComponent<ThirdPersonCharacter>().enabled = false;
        ThePlayer.transform.localScale -= new Vector3(0.0f, 0.7f, 0.0f);//dimnuer la taille de jour pour paraitre qu'il se detruit
        ThePlayer.GetComponent<CapsuleCollider>().enabled = false;//remove the payer's collider
        yield return new WaitForSeconds(1);
        GlobalScore.CurrentScore = 0; //put the score in zero if we die
        SceneManager.LoadScene(0); //reprendre le jeu
    }
}
