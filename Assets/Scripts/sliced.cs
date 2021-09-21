using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliced : MonoBehaviour
{
    public GameObject limit0, limit1, painting, paintingD,safe;
    private Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        anime = painting.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(limit1.activeSelf & limit0.activeSelf) 
        {
            gameObject.GetComponent<AudioSource>().Play();
            anime.SetFloat("destroyed", 1);
            paintingD.SetActive(true);
            painting.SetActive(false);
            safe.SetActive(true);
        }
    }
}
