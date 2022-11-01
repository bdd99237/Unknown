using UnityEngine;
using System.Collections;

public class Interaction_Door : Interaction {

    [SerializeField]
    AudioClip[] audios;

    public override void Action()
    {
        if(gameObject.tag == "Door")
        {
            GetComponent<Animation>().Play();
        }
        else if(gameObject.tag == "LockDoor")
        {
            if (PlayerController.getKey)
            {
                GetComponent<Animation>().Play();
            }
        }
    }

    public override void Sound()
    {
        if (gameObject.tag == "LockDoor")
        {
            if (PlayerController.getKey)
            {
                GetComponent<AudioSource>().clip = audios[0];
                PlayerController.getKey = false;
            }
            else
            {
                GetComponent<AudioSource>().clip = audios[1];
            }

            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
