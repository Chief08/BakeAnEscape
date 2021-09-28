using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliced : MonoBehaviour
{
    public GameObject limit0, limit1, painting, paintingD, safe;
    private Animator anime;
    private bool once;

    // Start is called before the first frame update
    void Start()
    {
        anime = painting.GetComponent<Animator>();
        once = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (limit1.activeSelf & limit0.activeSelf & once)
        {
            once = false;
            safe.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
            anime.SetFloat("destroyed", 1);
            paintingD.SetActive(true);
            painting.transform.position = new Vector3(10, 10, 10);
            StartCoroutine(Waiting(0.5f));

        }
    }

    private IEnumerator Waiting(float x)
    {
        yield return new WaitForSeconds(x);
        painting.GetComponent<PaintingFocus>().PaintingSliced();
        yield return null;
    }
}
