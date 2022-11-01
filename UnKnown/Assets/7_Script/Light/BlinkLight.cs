using UnityEngine;
using System.Collections;


public class BlinkLight : MonoBehaviour {

	public Color distortColor = Color.white; //변할 색상
	private Color baseColor = Color.white;
	float blinkFrequency = 1f; //깜빡임 빈도
	private float blinkIterator = 0f;
    public float min;
    public float max;
	private Light myLight;
    
	void Start()
    { 
        //베이스라이트를 얻음.
		myLight = gameObject.GetComponent< Light >();
		baseColor = myLight.color;
	}

	void Update()
	{
        ChangeColor();
    }

    void ChangeColor()
    {
        blinkIterator += 1f * Time.deltaTime; //시간 누적

        if (blinkIterator >= blinkFrequency)
        {
            //발생빈도를 랜덤하게 변경.
            blinkFrequency = Random.Range(min, max);
            blinkIterator = 0;

            //색상전환.
            if (myLight.color != distortColor)
            {
                myLight.color = distortColor;
            }
            else
            {
                myLight.color = baseColor;
            }
        }
    }
}
