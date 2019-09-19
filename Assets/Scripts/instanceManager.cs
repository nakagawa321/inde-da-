using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanceManager : MonoBehaviour
{
    public GameObject[] enemy = new　GameObject[3];
    private int Count = 1;
    private int minCount = 100, maxCount = 200;
    private int ramCount = 200;
    private float minPosX = -1.5f, maxPosX = 1.5f;
    private float enemyPosY = 9.0f;
    private float enemyPosZ = 0.0f;

    private enum ENEMYCOLOR
    {
        BLUE,
        GREEN,
        RED,
        MAX
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Count % ramCount) == 0)
        {
            ramCount = Random.Range(minCount, maxCount); //ランダム値取得
            Count = 0;
            // Cubeプレハブを元に、インスタンスを生成、
            Instantiate(enemy[Random.Range((int)ENEMYCOLOR.BLUE, (int)ENEMYCOLOR.MAX)], new Vector3(Random.Range(minPosX, maxPosX), enemyPosY, enemyPosZ), Quaternion.identity);
        }
        Count++;
    }

    public void instance(GameObject create, Transform pos)
    {
        // 弾丸の複製
        GameObject bullets = Instantiate(create) as GameObject;

        // 弾丸の位置を調整
        bullets.transform.position = pos.transform.position;
    }
}
