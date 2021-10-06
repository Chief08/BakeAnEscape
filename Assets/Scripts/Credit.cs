using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Credits());
    }

    
    private IEnumerator Credits()
    {
        yield return new WaitForSeconds(19);

        SceneManager.LoadScene("Menu");

    }


}
