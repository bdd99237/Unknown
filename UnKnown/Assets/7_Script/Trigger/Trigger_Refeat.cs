using UnityEngine;
using System.Collections;

public class Trigger_Refeat : Trigger_Delay
{
    public override void Action()
    {
        transform.GetComponent<BoxCollider>().enabled = false;
        base.Action();
    }

    public override IEnumerator Action_Delay()
    {
        for (int i = 0; i < targetObject.Length; i++)
        {
            if (i % 2 == 0)
            {
                yield return new WaitForSeconds(delayTime[0]);
                RenderSettings.fogDensity = 1f;
                targetObject[i].SetActive(true);
            }
            else
            {
                yield return new WaitForSeconds(delayTime[1]);
                RenderSettings.fogDensity = 0f;
                targetObject[i].SetActive(false);
            }
        }
    }
}
//setActiveCorutin를 대신하는 스크립트