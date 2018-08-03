using UnityEngine;
using System.Collections;

public class CollectGreenMushrooms : MonoBehaviour
{
    public AudioSource LifeSound; //son of collect mushroom

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") 
        {
            this.transform.position = new Vector3(0, -1000, 0); // if we touch mushroom it will be put in a so far place
            LifeSound.Play(); //play the sound
            GlobalLives.LivesAmount += 1;//the green mushroom will give the player an other live
        }
    }
}