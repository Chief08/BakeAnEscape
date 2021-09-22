using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairVelocity : MonoBehaviour
{
    public GameObject chair;
    private Rigidbody speedo;
    private AudioSource source0;

    private void Start()
    {
        speedo = chair.GetComponent<Rigidbody>();
        source0 = chair.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speedo.velocity.magnitude > 0.01  & GetfloorDist())
        {
            source0.volume = 1;
            Debug.Log(1);
        }
        else
        {
            source0.volume = 0;

            Debug.Log(0);
        }
    }

    private bool GetfloorDist()
    {
        return chair.transform.position.y < 0.13;
    }

}
