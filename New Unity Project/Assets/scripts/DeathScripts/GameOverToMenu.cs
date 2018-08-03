using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOverToMenu : MonoBehaviour
{
   IEnumerator Start()
    {
        yield return new WaitForSeconds(4);
        GlobalLives.LivesAmount += 3; // on reajoute le nombre initial de Lives au joueur
        SceneManager.LoadScene(2); // appel de la menu
    }
}
