using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveY_enemy : MonoBehaviour
{
    public GameObject bulletEnemy;
    private float speed = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= this.transform.up * speed * Time.deltaTime;
    }

    // 当たると消える
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 別のオブジェクト(Sphere)のスクリプトを参照する場合
        if (collision.gameObject.name != "bulletEnemy(Clone)")
        {
            Destroy(bulletEnemy);
        }
    }
}
