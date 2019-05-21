using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateController : MonoBehaviour
{
    GameObject obstacle;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("FPSController").transform.position;
        obstacle = GameObject.Find("Halberd_A");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target, 0.2f);
        if(transform.position == target)
        {
            Destroy(this.obstacle);
        }
    }



}
