using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newscript : MonoBehaviour
{
    public Transform startTransform,endTransform,cubeTransform;
    private bool loop = true;
    //public float A = 0.5f;
    
    
    //public float Wave(float A)
    //{
    //    return 0.5f* Mathf.Sin(Time.time)+0.5f;
    //}

    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        
            cubeTransform.position = Vector3.Lerp(startTransform.position, endTransform.position, 0.5f * Mathf.Sin(Time.time) + 0.5f);
            
        
        
        
            
        
        
        
        
    }
}
