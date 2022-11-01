using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetButtonUp("Fire4") || Input.GetButtonUp("Fire2"))
        {

           SceneManager.LoadScene("Title_Scene");

        }

	}
}
