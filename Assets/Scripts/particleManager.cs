using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleManager : MonoBehaviour
{
    public ParticleSystem windParticle;

    // Start is called before the first frame update
    void Start()
    {
        windParticle.Stop();　//最初はストップ
    }

    // Update is called once per frame
    void Update()
    {
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
