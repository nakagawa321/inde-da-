using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyBullet;
    public GameObject muzzle;
    private float min_enemyX = -0.25f, max_enemyX = 0.25f;
    private float min_enemyY = -0.01f, max_enemyY = -0.05f;
    private int Count = 0;
    private int minCount = 200, maxCount = 300;
    private int ramCount = 200;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // 敵の移動
        //  this.transform.position = new Vector3(this.transform.position.x + Random.Range(min_enemyX, max_enemyX), this.transform.position.y + Random.Range(min_enemyY, max_enemyY), this.transform.position.z);

        // 球
        if ((Count % ramCount) == 0)
        {
            ramCount = Random.Range(minCount, maxCount); //ランダム値取得

            // 弾丸の複製
            GameObject bullets = Instantiate(enemyBullet) as GameObject;

            // 弾丸の位置を調整
            bullets.transform.position = muzzle.transform.position;
        }
        Count++;
    }

    // 当たると消える
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bullet(Clone)" || collision.gameObject.name == "ziki")
        {
            Destroy(enemy);
        }
    }

}
