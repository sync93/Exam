using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public float currentSpeed;
    float WPradius = 1;
    public float cDtimer = 150f;

    bool speedlv2 = false;
    public float speed2;
    bool speedlv3 = false;
    public float speed3;
    bool speedlv4 = false;
    public float speed4;
    bool speedlv5 = false;
    public float speed5;

    void Start()
    {

    }


    void Update()
    {
        cDtimer -= Time.deltaTime;

        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0; ;
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * currentSpeed);

        if (cDtimer <= 120)
        {
            // Debug.Log("speed up 1");
            speedlv2 = true;


        }
        if (cDtimer <= 90)
        {
            //Debug.Log("speed up 2");
            speedlv3 = true;

        }
        if (cDtimer <= 60)
        {
            //Debug.Log("speed up 3");
            speedlv4 = true;

        }
        if (cDtimer <= 30)
        {
            //Debug.Log("speed up 4");
            speedlv5 = true;

        }



        if (speedlv2 == true)
        {
            currentSpeed = speed2;
        }
        if (speedlv3 == true)
        {
            currentSpeed = speed3;
        }
        if (speedlv4 == true)
        {
            currentSpeed = speed4;
        }
        if (speedlv5 == true)
        {
            currentSpeed = speed5;
        }

    }
}
