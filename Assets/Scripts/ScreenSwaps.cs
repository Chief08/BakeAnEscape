using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ScreenSwaps : MonoBehaviour
{
    public GameObject screenL,screenR;
    public VideoClip gas,logL, logR, riddleR, riddleL, emrgency, DrawerR, DrawerL; 

    public void ScreenLog() 
    {
        ChangeClip(screenR, logR);
        ChangeClip(screenL, logL);
    }

    public void ScreenRiddle()
    {
        ChangeClip(screenR, riddleR);
        ChangeClip(screenL, riddleL);
    }

    public void UnlockDrawer()
    {
        ChangeClip(screenR, DrawerR);
        ChangeClip(screenL, DrawerL);
    }

    public void GasOn()
    {
        ChangeClip(screenR, gas);
        ChangeClip(screenL, gas);
    }

    public void LockEverything()
    {
        ChangeClip(screenR, emrgency);
        ChangeClip(screenL, emrgency);
    }

    public void ChangeClip(GameObject screeno , VideoClip nextclip)
    {
        VideoPlayer source = screeno.GetComponent<VideoPlayer>();
        AudioSource audios = screeno.GetComponent<AudioSource>();
        source.Stop();
        audios.Stop();
        source.clip = nextclip;
        source.Play();
    }
}
