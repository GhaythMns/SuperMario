using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Endlev1 : MonoBehaviour
{

    public GameObject FadeScreen; //scene qui clignote
    public GameObject ThePlayer;
    public int TimeScore; //temps qui sera calculé
    public int TimeLeftInt; //temps restant apres termier le jeu

    IEnumerator OnTriggerEnter()
    {
        FadeScreen.SetActive(true);
        FadeScreen.GetComponent <Animator> ().enabled = true; //allumer la scene qui clignote
        TimeLeftInt = CountingDown.TimeLeft;
        TimeScore = TimeLeftInt * 10; //le temps restant multiplié par 10 
        GlobalScore.CurrentScore += TimeScore;//sera ajouté au score
        yield return new WaitForSeconds(0.495f);
        FadeScreen.GetComponent <Animator> ().enabled = false;//desactiver la scene qui clignote
        SceneManager.LoadScene(4);
    }
}