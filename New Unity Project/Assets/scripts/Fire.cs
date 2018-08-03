using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 0, -1, Space.World); //rotation of the fire
    }
}