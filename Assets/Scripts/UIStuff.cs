using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class UIStuff : MonoBehaviour
{
    public GameObject VRrig;


    public void StartButton()
    {
        VRrig.GetComponent<MyLoadScene>().Loadlevel("RoomZero");
    }

    public void Training()
    {
        VRrig.GetComponent<MyLoadScene>().Loadlevel("Training");
    }

    public void MainMenuButton()
    {
        VRrig.GetComponent<MyLoadScene>().Loadlevel("Menu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void HintSystem()
    {
        GameMaster.Hint = !GameMaster.Hint;
    }

    public void SkipRoom()
    {
        VRrig.GetComponent<MyLoadScene>().Loadlevel("RoomUno");
    }


}
