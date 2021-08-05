using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenlight : MonoBehaviour
{
    public GameObject spotlight;
    public GameObject lever;
    public GameObject leverlight;
    private Quaternion angle;
    private Light lt;
    private string alpha;
    private char letter;

    private void Start()
    {
        lt = leverlight.GetComponent<Light>();
        alpha = leverlight.name;
        letter = alpha[alpha.Length -1];

    }

    // Update is called once per frame
    void Update()
    {
        angle = lever.transform.rotation;
        if (angle.x < -0.3f)
        {
            lt.color = Color.green;
        }
        else
        {
            lt.color = Color.red;
        }
        if (Colorcheck(lt, Convert(letter)-1))
        {
            if (lever.GetComponent<FixedJoint>() == null)
                lever.AddComponent<FixedJoint>();
        }

    }

    public bool Colorcheck(Light lt, int i)
    {
        if ((lt.color == Color.green) == spotlight.GetComponent<LightsCheck>().list0[i])
            return true;
        else
            return false;
    }

    public int Convert(char x)
    {
        if (x == '0')
            return 10;
        if (x == '1')
            return 1;
        if (x == '2')
            return 2;
        if (x == '3')
            return 3;
        if (x == '4')
            return 4;
        if (x == '5')
            return 5;
        if (x == '6')
            return 6;
        if (x == '7')
            return 7;
        if (x == '8')
            return 8;
        else
            return 9;
    }

}