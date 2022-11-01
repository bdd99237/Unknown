using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Interaction_Button : Interaction {

    [SerializeField]
    string seenName;

    public override void Action()
    {
        if (seenName == "Exit")
        {
            Application.Quit();
        }
        else
        {
            // 타이틀의 버튼조작시 실행
            SceneManager.LoadScene(seenName);
        }
    }
}
