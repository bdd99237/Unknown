using UnityEngine;
using System.Collections;

public class CamerMove : MonoBehaviour {

    public float rotationSpeed = 20;

    // Update is called once per frame
    void Update ()
    {
            Joystic();
            KeyBord();
    }

    void Joystic()
    {
        if (Input.GetAxis("5Axis") > 0.19f || Input.GetAxis("5Axis") < -0.19f)
        {
            float rotation = Input.GetAxis("5Axis") * rotationSpeed * Time.deltaTime;
            transform.Rotate(rotation, 0, 0);
        }
    }

    void KeyBord()
    {
        //상하회전
        float rotation = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        transform.Rotate(-rotation, 0, 0);
    }
}
//VR의 문제로 인해 임시로 패드를 통해 조작하기 위한 부분.
