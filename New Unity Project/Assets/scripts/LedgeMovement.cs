using UnityEngine;
using System.Collections;

public class LedgeMovement : MonoBehaviour {

    float ResetPoint;
    float CurrentPoint;
    float XPos;
    float ZPos;
    

    void  Update (){
	ResetPoint = 7.3f;
        XPos = transform.position.x;
        CurrentPoint = transform.position.y;
        ZPos = transform.position.z;
        if (CurrentPoint >= ResetPoint) {
            transform.position = new Vector3(XPos, -1.5f, ZPos);
	}
	transform.Translate(Vector3.up * Time.deltaTime);
}

}