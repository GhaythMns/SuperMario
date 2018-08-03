using UnityEngine;
using System.Collections;

public class CollectMushrooms : MonoBehaviour
{
    public AudioSource GrowSound; //sound of ground
    public GameObject ThePlayer;

void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(0, -1000, 0);// if we touch the mushroom it will be put in a so far place
            GrowSound.Play();//play the sound
            ThePlayer.transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);//add 0.3 of the scale of player

        }
    }
}