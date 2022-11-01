using UnityEngine;
using System.Collections;

public class Trigger_Animation : Trigger
{
    [SerializeField]
    string play_Name;

    public override void Action()
    {
        foreach(GameObject obj in targetObject)
        {
            Animation animation = obj.GetComponent<Animation>();
            animation.Play(play_Name);
        }
    }
}
//Animation_Play대신 사용할 스크립트