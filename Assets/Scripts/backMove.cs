using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -14.0f)
        {
            this.transform.position = new Vector3(this.transform.position.x, 14.0f, this.transform.position.z);
        }
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.05f, this.transform.position.z);
    }
}
