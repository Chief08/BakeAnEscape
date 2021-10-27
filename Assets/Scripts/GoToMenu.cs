using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{

    public GameObject Card, Paper, Ball;
    private float dist0, dist1, dist2;
    // Start is called before the first frame update
    


    // Update is called once per frame
    void Update()
    {
        dist0 = Vector3.Distance(gameObject.transform.position, Card.transform.position);
        dist1 = Vector3.Distance(gameObject.transform.position, Paper.transform.position);
        dist2 = Vector3.Distance(gameObject.transform.position, Ball.transform.position);

        if (dist0 > 50 & dist1> 50 & dist2>50)
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
