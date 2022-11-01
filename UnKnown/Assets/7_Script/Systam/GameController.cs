using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    GameObject end_Seen;
    GameObject diary_Seen;
    
    void Start () {
        //게임의 종료를 안내하는 창
        end_Seen = GameObject.FindGameObjectWithTag("EndSeen");
        diary_Seen = GameObject.FindGameObjectWithTag("DiarySeen");

        end_Seen.SetActive(false);
        diary_Seen.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked; //마우스 락
        Cursor.visible = false; //마우스 숨김
    }
	
	void Update () {
        End_Window();
        Diary_Window();
    }


    //종료방법을 안내하는 창
    void End_Window()
    {
        if (Input.GetButtonUp("Submit"))
        {
            if (end_Seen.active)
            {
                end_Seen.SetActive(false);
            }
            else
            {
                end_Seen.SetActive(true);
            }
        }

        End_Key();
    }

    //타이틀 및 종료 조작
    void End_Key()
    {
        if (end_Seen.active)
        {
            if (Input.GetButtonUp("Fire2"))
            {
                GameEND();
            }
            else if (Input.GetButtonUp("Fire4"))
            {
                TitleSeenGo();
            }
        }
    }

    //게임종료
    void GameEND()
    {
        Application.Quit();
    }
    
    //타이틀화면
    void TitleSeenGo()
    {
        SceneManager.LoadScene("Title_Seen");
    }

    //다이어리 화면
    void Diary_Window()
    {
        if(Input.GetButtonUp("Fire4"))
        {
            if(diary_Seen.active)
            {
                Time.timeScale = 1;
                diary_Seen.SetActive(false);
            }
            else
            {
                diary_Seen.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}

//Test_Player_Ray를 대체하는 스크립트
//카메라에 부착될 스크립트
