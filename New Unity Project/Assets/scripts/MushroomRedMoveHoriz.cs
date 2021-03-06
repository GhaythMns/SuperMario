﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomRedMoveHoriz : MonoBehaviour {

    public float LeftPoint = 2;
    public float RightPoint =21;
    public int Direction = 1;  //  1 = moving right, 2 = moving left


    void Update()
    {
        transform.parent = null;
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
}
