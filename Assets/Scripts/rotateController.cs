﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateController : MonoBehaviour
{
    GameObject obstacle;
    GameObject terrain;
    Vector3 target;
    public GameObject cube;
    public Vector3 testPosition = new Vector3();

    public int test=0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("FPSController").transform.position;
        obstacle = GameObject.Find("Halberd_A");
        terrain = GameObject.Find("Terrain");
        cube = GameObject.Find("place1");
    }

    // Update is called once per frame
    void Update()
    {
        if(test != 0) {
            Vector3 test = new Vector3(0, 2, 0);
            transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, testPosition, 0.3f);
        }
    }

    public void setPosition(int a,Vector3 b)
    {
        test = a;
        testPosition = b;
    }

}
