using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocitytracking : MonoBehaviour
{
    public GameObject head, card;
    private Rigidbody speedo;

    private void Start()
    {
        speedo = head.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(speedo.velocity.magnitude > 0.1)
        {
            card.SetActive(true);
        }
    }
}
