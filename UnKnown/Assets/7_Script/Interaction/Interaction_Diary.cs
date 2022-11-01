using UnityEngine;
using System.Collections;

public class Interaction_Diary : Interaction {

    [SerializeField]
    GameObject piece;

    public override void Action()
    {
        piece.SetActive(true);
        Destroy(gameObject, 0.3f);
    }
}
