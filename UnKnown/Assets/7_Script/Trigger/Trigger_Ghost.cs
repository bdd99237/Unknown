using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger_Ghost : Trigger_Delay
{
    public override IEnumerator Action_Delay()
    {
        yield return new WaitForSeconds(delayTime[0]);
        GetComponent<PlayerChange>().enabled = false;
        targetObject[0].GetComponent<Animator>().speed += 1f;
        yield return new WaitForSeconds(delayTime[1]);
        GetComponent<AudioSource>().Play();
        targetObject[1].SetActive(true);
        targetObject[2].SetActive(false);
        yield return new WaitForSeconds(delayTime[2]);
        RenderSettings.fog = true;
        RenderSettings.fogColor = Color.black;
        RenderSettings.fogDensity = 1.0f;
        yield return new WaitForSeconds(delayTime[3]);
        SceneManager.LoadScene("Ending");
    }
}
