using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionZiki : MonoBehaviour
{
    public soundManager soundmanager = new soundManager();
    public GameObject[] hp = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 当たるとhp削る
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemy1(Clone)" || collision.gameObject.name == "enemy2(Clone)" || collision.gameObject.name == "enemy3(Clone)" ||  collision.gameObject.name == "bulletEnemy(Clone)")
        {
            if (hp[2] != null)
            {
                Destroy(hp[2]);
            } else if (hp[1] != null)
            {
                Destroy(hp[1]);
            } else if (hp[0] != null)
            {
                soundmanager.playSound_bomb();
                Destroy(hp[0]);
                // ゲームオーバー
                SceneManager.LoadScene("Finish");
            }
        }
    }

}
