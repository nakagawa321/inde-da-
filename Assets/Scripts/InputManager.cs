using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public particleManager particleManager;
    public Joystick joystick;
    public GameObject airplane;
    private float moveSpeed = 2f;
    private float downLimit = -6.0f, upLimit = 6.6f;
    private float undoPosition_Num = 0.05f;
    void start()
    {
    }

    void Update()
    {
        if (downLimit < airplane.transform.position.y) // 下、場外に行かないように
        {
            joystickController(); // ジョイスティック動き
        } else
        {
            airplane.transform.position = new Vector3(airplane.transform.position.x, downLimit + undoPosition_Num, airplane.transform.position.z);
        }
        if (airplane.transform.position.y < upLimit) // 上、場外に行かないように
        {
            joystickController(); // ジョイスティック動き
        }
        else
        {
            airplane.transform.position = new Vector3(airplane.transform.position.x, upLimit - undoPosition_Num, airplane.transform.position.z);
        }
    }

    // ジョイスティック処理
    void joystickController()
    {
        //joy stickの動き
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical);

        //Vector.zero : (0,0,0)なので、動いたら….
        if (moveVector != Vector3.zero)
        {
            particleManager.playParticle_wind(); // エフェクト開始
            //移動…movespeedは移動速度のパラメータ。
            airplane.transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        } else
        {
            particleManager.stopParticle_wind(); // エフェクト停止
        }
    }

}