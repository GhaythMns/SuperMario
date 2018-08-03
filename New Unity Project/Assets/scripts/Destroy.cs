using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    public float XPos;
    public float YPos;
    public float ZPos;
    private new Collider collider;

    void Start()
    {
        XPos = transform.position.x;
        YPos = transform.position.y;
        ZPos = transform.position.z;
        collider = this.GetComponent<Collider>();
    }
    IEnumerator OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(XPos, YPos + 0.3f, ZPos);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos + 0.2f, ZPos);
            yield return new WaitForSeconds(0.06f);
            this.collider.isTrigger = false;
            this.transform.position = new Vector3(XPos, YPos + 0.3f, ZPos + 0.5f);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos + 0.4f, ZPos + 1.0f);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos - 0.1f, ZPos + 1.5f);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos - 0.6f, ZPos + 2.0f);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos - 1.6f, ZPos + 2.0f);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos - 2.6f, ZPos + 2.0f);
            yield return new WaitForSeconds(0.06f);
            this.transform.position = new Vector3(XPos, YPos - 4.0f, ZPos + 2.0f);
            yield return new WaitForSeconds(0.25f);
            this.collider.isTrigger = true;
            Destroy(gameObject);
        }
    }
}//when the player touch the cube by his head the position of cube will be change 