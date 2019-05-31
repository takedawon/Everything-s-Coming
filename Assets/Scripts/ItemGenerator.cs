using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject halberdPrefab;
    float span = 5.0f;
    float delta = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            for(int i=0; i<=16;i++) { 
                Instantiate(halberdPrefab);
            }
        }
    }
}
