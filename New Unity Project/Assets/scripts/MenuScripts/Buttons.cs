using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour {
public void  PlayGame (){
        SceneManager.LoadScene(0); // appel a la scene 0 
    }

public void  QuitGame (){
	Application.Quit(); // quitter le jeu
}
}