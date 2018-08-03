using UnityEngine;
using System.Collections;

public class BossTriggerFreeze : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject BackWall; //the wall that will be detacted by the player

    void OnTriggerEnter()
    {
        MainCam.GetComponent <cameraFollow> ().enabled = false;
        BackWall.SetActive(true);
    }
}
//this script will fix the main camera on a position and also the player can not move back when he attends this position