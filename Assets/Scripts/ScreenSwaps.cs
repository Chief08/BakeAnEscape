using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ScreenSwaps : MonoBehaviour
{
    public GameObject screenL,screenR;
    public VideoClip gasR, gasL, logL, logR, riddleR, riddleL, emrgency, DrawerR, DrawerL,poweOn;
    public GameObject Box1, Box2, Box3, Console0, Console1, Volume, Card, CardHolder;

    private void Start()
    {
        //StartCoroutine(Testingneeds());
    }

    public void ScreenLog()
    {
        Box3.GetComponent<FocusStaff>().SetUnfocused();
        CardHolder.GetComponent<FocusStaff>().SetFocused();
        Card.GetComponent<FocusStaff>().SetFocused();
        ChangeClip(screenR, logR);
        ChangeClip(screenL, logL);
    }

    public void ScreenRiddle()
    {
        CardHolder.GetComponent<FocusStaff>().SetUnfocused();
        Card.GetComponent<FocusStaff>().SetUnfocused();
        Console0.GetComponent<FocusStaff>().SetFocused();
        Console1.GetComponent<FocusStaff>().SetFocused();
        Box2.GetComponent<FocusStaff>().SetFocused();
        ChangeClip(screenR, riddleR);
        ChangeClip(screenL, riddleL);
    }
    public void UnlockDrawer()
    {
        ChangeClip(screenR, DrawerR);
        ChangeClip(screenL, DrawerL);
        Volume.SetActive(false);
    }

    public void PowerOn()
    {
        ChangeClip(screenR, poweOn);
        ChangeClip(screenL, poweOn);
    }

    public void GasOn()
    {
        Box3.GetComponent<FocusStaff>().SetFocused();
        Box1.GetComponent<FocusStaff>().SetUnfocused();
        ChangeClip(screenR, gasR);
        ChangeClip(screenL, gasL);
    }

    public void LockEverything()
    {
        ChangeClip(screenR, emrgency);
        ChangeClip(screenL, emrgency);
    }

    public IEnumerator SoundFirst(AudioClip clipaki) 
    {
        VideoPlayer source = screenR.GetComponent<VideoPlayer>();
        AudioSource audios = screenR.GetComponent<AudioSource>();
        source.Stop();
        audios.Stop();
        audios.clip = clipaki;
        audios.Play();
        Debug.Log("wtf");
        yield return new WaitForSeconds(1);
        ScreenRiddle();
        yield return null;
    }

    public void ChangeClip(GameObject screeno , VideoClip nextclip)
    {
        VideoPlayer source = screeno.GetComponent<VideoPlayer>();
        AudioSource audios = screeno.GetComponent<AudioSource>();
        source.Stop();
        audios.Stop();
        source.clip = nextclip;
        source.Play();
        Debug.Log(nextclip.name);
    }

    private IEnumerator Testingneeds()
    {
        yield return new WaitForSeconds(2f);
        ScreenLog();
        yield return new WaitForSeconds(2f);
        ScreenRiddle();
        yield return new WaitForSeconds(2f);
        UnlockDrawer();
        yield return new WaitForSeconds(2f);
        LockEverything();
        yield return new WaitForSeconds(2f);
        GasOn();
    }
}
