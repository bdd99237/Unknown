using UnityEngine;
using System.Collections;

public class Interaction_Key : Interaction
{
    public override void Action()
    {
        PlayerController.getKey = true;
        Destroy(gameObject, 0.3f);
    }
}
