using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class enemyMove : MonoBehaviour
{
    public GameObject scripts;
    public GameObject enemy;
    public GameObject enemyBullet;
    public Transform muzzle;
    public ParticleSystem particle;
    private float min_enemyX = -0.1f, max_enemyX = 0.1f;
    private float min_enemyY = -0.01f, max_enemyY = -0.05f;
    private int Count = 1;
    private int minCount = 50, maxCount = 200;
    private int ramCount = 200;



    // Start is called before the first frame update
    void Start()
    {
        scripts = GameObject.Find("Scripts");
        particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        // 敵の移動
        this.transform.position = new Vector3(this.transform.position.x + Random.Range(min_enemyX, max_enemyX), this.transform.position.y + Random.Range(min_enemyY, max_enemyY), this.transform.position.z);

        // 球
        if ((Count % ramCount) == 0)
        {
            scripts.GetComponent<soundManager>().playSound_shot(); // ショット音
            ramCount = Random.Range(minCount, maxCount); //ランダム値取得
            Count = 0;
            // 別のオブジェクト(Sphere)のスクリプトを参照する場合
            scripts.GetComponent<instanceManager>().instance(enemyBullet, muzzle);
        }
        Count++;


    }

    // 当たると消える
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bullet(Clone)" || collision.gameObject.name == "ziki" || collision.gameObject.name == "Cube (4)")
        {
            scripts.GetComponent<soundManager>().playSound_bomb(); // 爆発音
            Instantiate(particle, this.transform.position, this.transform.rotation); // パーティクル
            scripts.GetComponent<particleManager>().set_particleMode(true); // パーティクル
            Destroy(enemy);
        }
    }

}
