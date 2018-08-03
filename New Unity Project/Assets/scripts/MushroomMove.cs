using UnityEngine;
using System.Collections;

public class MushroomMove : MonoBehaviour
{
    public float LeftPoint = 18;
    public float RightPoint = 34;
    public int Direction = 1;  //  1 = moving right, 2 = moving left


    void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            Direction = 1;
        }

        if (this.transform.position.x > RightPoint)
        {
            Direction = 2;
        }

        if (Direction == 2)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            Direction = 2;
        }

        if (this.transform.position.x < LeftPoint)
        {
            Direction = 1;
        }
    }
}//move the mushroom between 18 and 34