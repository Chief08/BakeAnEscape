using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AngleCheck : MonoBehaviour
{
    public GameObject obj,screen,lighto,spotlight0,spotlights1, door2, siren0, siren1;
    private Quaternion angle;
    public bool doStuff;
    private VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = screen.GetComponent<VideoPlayer>();
        doStuff = true;
    }

    // Update is called once per frame
    void Update()
    {
        angle = obj.transform.rotation;
        if (angle.x > 0.68f) 
        {   
            if(doStuff)
            {
                doStuff = !doStuff;
                lighto.SetActive(true);

            }
            siren1.SetActive(false);
            siren0.SetActive(false);
            spotlight0.SetActive(true);
            spotlights1.SetActive(true);
            door2.GetComponent<AngleLockFree>().Freee();

            player.Play();
        }
        else
        {
            siren0.SetActive(true);
            siren1.SetActive(true);
            doStuff = true;
            lighto.SetActive(false);
            spotlight0.SetActive(false);
            spotlights1.SetActive(false);
            door2.GetComponent<AngleLockFree>().Lock();

            player.Stop();
        }
    }
}
