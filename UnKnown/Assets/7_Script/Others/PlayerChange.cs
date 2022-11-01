using UnityEngine;
using System.Collections;

public class PlayerChange : MonoBehaviour {

    public GameObject[] players;

    public float waitTime;

    public bool changebody = false;

    void Update()
    {
        if (changebody == true)
        {
            if (RenderSettings.fogDensity > 0)
            {
                RenderSettings.fogDensity -= 0.01f;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (changebody == false)
            {
                StartCoroutine("TimeWait");
            }
        }
    }

    IEnumerator TimeWait()
    {
        yield return new WaitForSeconds(waitTime);
        players[0].SetActive(false);
        yield return new WaitForSeconds(waitTime);
        players[1].SetActive(true);
        RenderSettings.fogDensity = 1f;
        changebody = true;
    }
}