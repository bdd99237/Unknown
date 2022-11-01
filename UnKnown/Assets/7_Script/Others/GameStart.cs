using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1")|| Input.GetButtonDown("Fire2")|| Input.GetButtonDown("Fire3")|| Input.GetButtonDown("Fire4"))
        {
            SceneManager.LoadScene("Play_Scene");
        }
    }
}
