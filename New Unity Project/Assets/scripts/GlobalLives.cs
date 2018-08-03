using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalLives : MonoBehaviour
{
    public static int LivesAmount = 3;//*we put 3 lives when we start the game
    public int InternalLives;
    public GameObject LifeTextBox;

   void Update()
    {
        InternalLives = LivesAmount;
        LifeTextBox.GetComponent<UnityEngine.UI.Text>().text = "" + InternalLives;
        if (InternalLives == 0)
        {
            StartCoroutine(GameOverScene());
        }

       
    }
    IEnumerator GameOverScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);//appload the scene of game over
    }



}