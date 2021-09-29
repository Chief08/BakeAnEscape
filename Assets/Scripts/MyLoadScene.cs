using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyLoadScene : MonoBehaviour
{

    public GameObject Depth,Assist;


    void Start()
    {
        AudioListener.volume = GameMaster.MasterVolume;
        Depth.SetActive(GameMaster.Hint);
    }

    public void DepthSet()
    {
        Depth.SetActive(Assist.GetComponent<Toggle>().isOn);
    }
 
    public void Loadlevel(string level)
    {
        GameMaster.MasterVolume = AudioListener.volume;
        GameMaster.Hint = Depth.activeSelf;
        SceneManager.LoadScene(level);

    }
}
