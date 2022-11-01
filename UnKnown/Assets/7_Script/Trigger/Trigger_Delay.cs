using UnityEngine;
using System.Collections;

public class Trigger_Delay : Trigger
{
    public float[] delayTime;

    public override void Action()
    {
        StartCoroutine(Action_Delay());
    }

    public virtual IEnumerator Action_Delay()
    {

        yield return null;
    }
}
