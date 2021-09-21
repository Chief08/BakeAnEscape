using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    public GameObject screen, limit0, limit1, door;
    private bool onlyonce ;
    public AudioClip audioclip0;

    private void Start()
    {
        onlyonce = true;
    }

    void Update()
    {   
        if(limit0.activeSelf & limit1.activeSelf & onlyonce)
        {
            onlyonce = false;
            gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(screen.GetComponent<ScreenSwaps>().SoundFirst(audioclip0));
            door.GetComponent<AngleLockFree>().Freee();
        }
    }
}
