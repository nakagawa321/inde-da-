using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float moveSpeed = 8f;
    public Joystick joystick;
    public GameObject airplane;

    void start()
    {
    }

    void Update()
    {

        //joy stickの動き
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical);

        //Vector.zero : (0,0,0)なので、動いたら….

        if (moveVector != Vector3.zero)
        {

            //移動…movespeedは移動速度のパラメータ。
            airplane.transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}