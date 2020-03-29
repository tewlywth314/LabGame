using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public GameObject player;
    public GameObject Win;

    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
    }

    // Update is called once per frame
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(player))
        {
            Debug.Log("Win");
            Win.SetActive(true);
        }
    }
}
