using UnityEngine;
using System.Collections;

public class Trigger_Light : Trigger {

    public float delayTime;
    public AudioSource audio;

    public override void Action()
    {
            transform.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine("TimeWait");
    }

    IEnumerator TimeWait()
    {
        RenderSettings.fogDensity = 0f;

        foreach(GameObject obj in targetObject)
        {
            yield return new WaitForSeconds(delayTime);
            audio.Play();
            obj.SetActive(false);
        }

        RenderSettings.fogDensity = 0.2f;
    }

}
