using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateController : MonoBehaviour
{
    GameObject obstacle;
    GameObject terrain;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("FPSController").transform.position;
        obstacle = GameObject.Find("Halberd_A");
        terrain = GameObject.Find("Terrain");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 test = new Vector3(0, 2, 0);
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target - test, 0.2f);

    }

}
