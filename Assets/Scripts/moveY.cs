using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveY : MonoBehaviour
{
    public GameObject bullet;
    private float speed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    // 当たると消える
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "bullet(Clone)")
        {
            Destroy(bullet);
        }
    }

}
