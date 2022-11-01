using UnityEngine;
using System.Collections;

public class Trigger_Blink : Trigger_Delay
{
    [SerializeField]
    bool active;

    public bool destroy;

    public override IEnumerator Action_Delay()
    {
        yield return new WaitForSeconds(delayTime[0]);
        foreach (GameObject obj in targetObject)
        {
            obj.SetActive(active);
        }
        yield return new WaitForSeconds(delayTime[1]);
        foreach (GameObject obj in targetObject)
        {
            obj.SetActive(!active);
        }
        if (destroy)
        {
            Destroy(gameObject);
        }
    }
}
//setActiveFalse를 대신하는 스크립트
