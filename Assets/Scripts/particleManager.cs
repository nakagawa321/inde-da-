using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleManager : MonoBehaviour
{
    public ParticleSystem windParticle;
    private int effectCnt = 1;
    private bool particleMode = false;

    // Start is called before the first frame update
    void Start()
    {
        windParticle.Stop();　//最初はストップ
    }

    // Update is called once per frame
    void Update()
    {
        // エフェクト処理
        if (particleMode == true)
        {
            if ((effectCnt % 10) == 0)
            {
                effectCnt = 1;
                set_particleMode(false);
                GameObject hieraruParticle = GameObject.Find("bomb(Clone)");
                if (hieraruParticle != null) //ヒエラルキーにパーティクルがあるか
                {
                    Destroy(hieraruParticle);
                }
            }
            effectCnt++;
        }
    }

    public void set_particleMode(bool particleMode)
    {
        this.particleMode = particleMode;
    }

    public void playParticle_wind()
    {
        windParticle.Play(); // パーティクルスタート
    }

    public void stopParticle_wind()
    {
        windParticle.Stop(); // パーティクルストップ
    }

}
