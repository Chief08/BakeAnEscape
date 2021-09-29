using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongsPlayer : MonoBehaviour
{
    //public AudioClip Boris, Artic, Peggy, Vivaldi, Skrillex, Lex, French79, ACDC, Oasis;

    private AudioSource source;
    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    public void PlaySong(AudioClip song)
    {
        source.Stop();
        source.clip = song;
        source.Play();
    }


}
