using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject goal;
    private void OnMouseDrag()
    {
        Vector3 MousePosWorld = Input.mousePosition;
        MousePosWorld.z = transform.position.z - Camera.main.transform.position.z;
        MousePosWorld = Camera.main.ScreenToWorldPoint(MousePosWorld);
        transform.position = new Vector3(MousePosWorld.x,MousePosWorld.y,MousePosWorld.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(goal))
        {
            Debug.Log("Win");
        }
    }
}
