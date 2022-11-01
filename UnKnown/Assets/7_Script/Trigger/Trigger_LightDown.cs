using UnityEngine;
using System.Collections;

public class Trigger_LightDown : Trigger
{
    public float[] waitTime;

    int finalObj;

    void Start()
    {

        finalObj = targetObject.Length;

    }

    public override void Action()
    {
        transform.GetComponent<BoxCollider>().enabled = false;

        StartCoroutine("Lightdown");
    }

    IEnumerator Lightdown()
    {
        for (int i = 0; i < targetObject.Length; i++)
        {
            if (i < targetObject.Length-1)
            {
                if (i % 2 == 0)
                {
                    yield return new WaitForSeconds(waitTime[0]);
                    RenderSettings.fogDensity = 1f;
                    targetObject[i/2].SetActive(false);
                }
                else
                {
                    yield return new WaitForSeconds(waitTime[1]);
                    RenderSettings.fogDensity = 0f;
                }
            }
            else
            {
                targetObject[finalObj-1].SetActive(true);
                yield return new WaitForSeconds(waitTime[1]);
                RenderSettings.fogDensity = 0f;
            }
        }
    }

}