using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundSet : MonoBehaviour
{
    public GameObject SFX;
    public GameObject Hint;
    // Start is called before the first frame update
    void Start()
    {

        Hint.GetComponent<Toggle>().isOn = GameMaster.Hint;
        SFX.GetComponent<Scrollbar>().value = GameMaster.MasterVolume;
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = SFX.GetComponent<Scrollbar>().value;
    }
}
