using UnityEngine;
using System.Collections;

public class Trigger_FaceFront : Trigger {
    [SerializeField]
    Vector3 distance;

    public override void Action(Collider other)
    {
        foreach(GameObject obj in targetObject)
        {
            obj.SetActive(true);
            obj.transform.position = new Vector3(other.transform.position.x + distance.x, other.transform.position.y + distance.y, other.transform.position.z + distance.z);
        }
    }
}
//SetActivemyface를 대체 하는 스크립트