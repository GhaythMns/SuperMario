using UnityEngine;
using System.Collections;


public class CoinPickUp : MonoBehaviour
{
    public AudioSource CoinAudio; //audio of collecting coins

    void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0); //faire envoyer le  coin a une place indetectable par le camera apres etre attaqué par le joueur 
        CoinAudio.Play();//play audio
        FindObjectOfType<GlobalCoins>().AddCoins();//ajouter chaque coin au nbre total des coins
        GlobalScore.CurrentScore += 10;//chaque coin ajoute 10pts au score 
    }
}