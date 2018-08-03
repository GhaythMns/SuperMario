using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathMushroomBoss : MonoBehaviour
{
    public GameObject MushroomMan;
    public AudioSource MushDeathSound;

    IEnumerator OnTriggerEnter(Collider col)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MushroomMan.GetComponent < MushroomMove > ().enabled = false;
        MushroomMan.transform.localScale -= new Vector3(0, 0,0);
        MushroomMan.transform.localPosition -= new Vector3(0, 0.4f, 0);
        MushDeathSound.Play();
        GlobalScore.CurrentScore += 50; //if i kill the Mushroom i win +50 into my score :D
        yield return new WaitForSeconds(1);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(6);
    }
}