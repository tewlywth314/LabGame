using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public Transform player;
    public GameObject goal;
    public float speed = 1.0f;
    public float Distance;
    Rigidbody rb;
    private void Start()
    {
        Distance = Vector3.Distance(player.position, cam.transform.position);
        rb = player.GetComponent<Rigidbody>();
    }
    private void OnMouseDrag()
    {

        Vector3 MousePosWorld = Input.mousePosition;

        MousePosWorld.z = Distance;

        MousePosWorld = Camera.main.ScreenToWorldPoint(MousePosWorld);
       
     
        rb.velocity = (MousePosWorld - player.position)*2 ;
        //transform.position = new Vector3(MousePosWorld.x,1.6f,MousePosWorld.z);
        
    }
    private void OnMouseUp()
    {
        rb.velocity = Vector3.zero;
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(goal))
        {
            Debug.Log("Win");
        }
    }
}
