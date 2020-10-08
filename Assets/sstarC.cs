using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sstarC : MonoBehaviour
{
    private float rotspeed = 3.0f;

    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotspeed, 0);
    }
}
