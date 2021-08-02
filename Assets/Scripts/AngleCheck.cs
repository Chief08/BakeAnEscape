using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AngleCheck : MonoBehaviour
{
    public GameObject obj,screen;
    private Quaternion angle;
    public bool doStuff;
    private VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = screen.GetComponent<VideoPlayer>();
        doStuff = false;
    }

    // Update is called once per frame
    void Update()
    {
        angle = obj.transform.rotation;
        if (angle.x > 0.68f) 
        {
            player.Play();
        }
        else
        {
            player.Pause();
        }
    }
}
