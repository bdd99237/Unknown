using UnityEngine;
using System.Collections;

public class Trigger_Fog : Trigger_Delay
{

    [SerializeField]
    float density;

    public override IEnumerator Action_Delay()
    {
        yield return new WaitForSeconds(delayTime[0]);
        RenderSettings.fog = true;
        RenderSettings.fogColor = Color.black;
        RenderSettings.fogDensity = 1f;

        yield return new WaitForSeconds(delayTime[1]);
        RenderSettings.fogColor = Color.black;
        RenderSettings.fogDensity = density;
    }
}
//fogTriggerd를 대신하는 스크립트