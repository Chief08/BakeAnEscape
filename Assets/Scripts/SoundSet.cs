using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundSet : MonoBehaviour
{
    public GameObject SFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = SFX.GetComponent<Scrollbar>().value;
    }
}
