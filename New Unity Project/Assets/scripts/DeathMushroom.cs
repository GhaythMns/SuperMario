using UnityEngine;
using System.Collections;

public class DeathMushroom : MonoBehaviour
{
    public GameObject MushroomMan;
    public AudioSource MushDeathSound;

    IEnumerator OnTriggerEnter(Collider col)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MushroomMan.GetComponent < MushroomMove > ().enabled = false;
        MushroomMan.transform.localScale -= new Vector3(0, 0.8f, 0);
        MushroomMan.transform.localPosition -= new Vector3(0, 0.4f, 0);
        MushDeathSound.Play();
        GlobalScore.CurrentScore += 50;//add 50 pts to the score if we kill the dangerous mushroom
        yield return new WaitForSeconds(1);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);// if we jump on the mushroom it will be put in a so far place
    }
}