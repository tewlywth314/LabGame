using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject box;
    public GameObject spike;
    // Start is called before the first frame update
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(box))
        {
            Debug.Log("Win");
            spike.SetActive(false);
        }
    }
}
