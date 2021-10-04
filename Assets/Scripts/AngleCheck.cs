using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AngleCheck : MonoBehaviour
{
    public GameObject obj,screen,screen1,lighto,spotlight0,spotlights1, door2, siren0, siren1;
    private Quaternion angle;
    public bool doStuff;
    private VideoPlayer player,player1;
    private VideoClip previous,previous1;

    // Start is called before the first frame update
    void Start()
    {
        player = screen.GetComponent<VideoPlayer>();

        player1 = screen1.GetComponent<VideoPlayer>();
        doStuff = false;

    }

    // Update is called once per frame
    void Update()
    {
        angle = obj.transform.rotation;
        if (angle.x > 0.68f) 
        {   
            if(doStuff)
            {
                gameObject.GetComponent<AudioSource>().Play();
                doStuff = !doStuff;
                lighto.SetActive(true);
                player.Stop();
                player.clip = previous;
                player.Play();

                player1.Stop();
                player1.clip = previous1;
                player1.Play();

            }
            siren1.SetActive(false);
            siren0.SetActive(false);
            spotlight0.SetActive(true);
            spotlights1.SetActive(true);
            door2.GetComponent<AngleLockFree>().Freee();
            
            //if (player.clip.name == "poweron")
            //{
            //    screen.GetComponent<ScreenSwaps>().GasOn();
            //}
        }
        else
        {
            siren0.SetActive(true);
            siren1.SetActive(true);
            if (!doStuff)
            {
                previous = player.clip;
                previous1 = player1.clip;
                screen.GetComponent<ScreenSwaps>().PowerOn();
                doStuff = true;

            }
            lighto.SetActive(false);
            spotlight0.SetActive(false);
            spotlights1.SetActive(false);
            door2.GetComponent<AngleLockFree>().Lock();

        }
    }
}
