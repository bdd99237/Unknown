using UnityEngine;
using System.Collections;

public class JoystickMove : MonoBehaviour
{
    public float rotationSpeed = 0;
    public float speed = 0;

    void Update()
    {
        joystic();
        KeyBord();
    }

    void joystic()
    {
            float translationZ = Input.GetAxis("Vertical") * speed;
            translationZ *= Time.deltaTime;    
            float translationX = Input.GetAxis("Horizontal") * speed;
            translationX *= Time.deltaTime;
            transform.Translate(translationX, 0, translationZ);    

        if (Input.GetAxis("4Axis") > 0.19f || Input.GetAxis("4Axis") < -0.19f)
        {
            float rotation = Input.GetAxis("4Axis") * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }
    }

    void KeyBord()
    {
        //상하이동
        float translationZ = Input.GetAxis("Key_Vertical") * speed;
        translationZ *= Time.deltaTime;
        //좌우 이동
        float translationX = Input.GetAxis("Key_Horizontal") * speed;
        translationX *= Time.deltaTime;
        //적용
        transform.Translate(translationX, 0, translationZ);
        //좌우회전
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }

}
