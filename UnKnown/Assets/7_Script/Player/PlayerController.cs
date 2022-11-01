using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //스크린의 중앙으로 레이캐스트를 사용
    Ray ray;
    RaycastHit hit;

    Interaction oldTarget; //상호작용 대상을 저장.

    static public bool getKey = false; //키의 습득유무를 저장.

    void Start () {

    }
	
	void Update () {
        StartCoroutine(Object_Interaction());
    }

    //물체들과의 상호작용
    IEnumerator Object_Interaction()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit, 500.0f))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red); //ray확인

            Effect(hit.transform);

            if (Input.GetButtonUp("Fire2"))
            {
                Interaction();
            }
        }
        yield return null;
    }

    //현재 보고 있는 상호작용 가능한 물체 이펙트 온오프부분
    void Effect(Transform target)
    {
        if (target.tag == "GameObject" || target.tag == "Door" || target.tag == "Undoor" || target.tag == "LockDoor")
        {
            oldTarget = target.GetComponent<Interaction>();
            oldTarget.Active_Effect();
        }
        else
        {
            if (oldTarget != null)
            {
                oldTarget.DeActive_Effect();
                oldTarget = null;
            }
        }
    }

    //상호작용
    void Interaction()
    {
        if(oldTarget != null)
        {
            oldTarget.Action();
            oldTarget.Sound();
        }
    }

}

//Test_Player_Ray 대체하는 스크립트
//플레이어가 가질 스크립트