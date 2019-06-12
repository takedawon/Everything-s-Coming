using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemGenerator3 : MonoBehaviour
{
    public GameObject halberdPrefab;
    public List<GameObject> cube = new List<GameObject>();
    float span = 5.0f;
    float delta = 0;
    int[] ran=new int[5];
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube1 = GameObject.Find("place1");
        GameObject cube2 = GameObject.Find("place2");
        GameObject cube3 = GameObject.Find("place3");
        GameObject cube4 = GameObject.Find("place4");
        GameObject cube5 = GameObject.Find("place5");
        GameObject cube6 = GameObject.Find("place6");
        GameObject cube7 = GameObject.Find("place7");
        GameObject cube8 = GameObject.Find("place8");
        GameObject cube9 = GameObject.Find("place9");
        GameObject cube10 = GameObject.Find("place10");
        GameObject cube11 = GameObject.Find("place11");
        GameObject cube12 = GameObject.Find("place12");
        GameObject cube13 = GameObject.Find("place13");
        GameObject cube14 = GameObject.Find("place14");
        GameObject cube15 = GameObject.Find("place15");
        GameObject cube16 = GameObject.Find("place16");
        GameObject cube17 = GameObject.Find("place17");
        GameObject cube18 = GameObject.Find("place18");
        GameObject cube19 = GameObject.Find("place19");
        GameObject cube20 = GameObject.Find("place20");
        GameObject cube21 = GameObject.Find("place21");
        GameObject cube22 = GameObject.Find("place22");
        GameObject cube23 = GameObject.Find("place23");
        GameObject cube24 = GameObject.Find("place24");
        GameObject cube25 = GameObject.Find("place25");
        GameObject cube26 = GameObject.Find("place26");
        GameObject cube27 = GameObject.Find("place27");
        GameObject cube28 = GameObject.Find("place28");

        cube.Add(cube1);
        cube.Add(cube2);
        cube.Add(cube3);
        cube.Add(cube4);
        cube.Add(cube5);
        cube.Add(cube6);
        cube.Add(cube7);
        cube.Add(cube8);
        cube.Add(cube9);
        cube.Add(cube10);
        cube.Add(cube11);
        cube.Add(cube12);
        cube.Add(cube13);
        cube.Add(cube14);
        cube.Add(cube15);
        cube.Add(cube16);
        cube.Add(cube17);
        cube.Add(cube18);
        cube.Add(cube19);
        cube.Add(cube20);
        cube.Add(cube21);
        cube.Add(cube22);
        cube.Add(cube23);
        cube.Add(cube24);
        cube.Add(cube25);
        cube.Add(cube26);
        cube.Add(cube27);
        cube.Add(cube28);

    }
    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            count++;
            ran = GetRandomInt(3, 1, 28);
            for (int i=1; i<=28;i++) { 
                if(i==ran[0] || i==ran[1])
                    continue;
               
                Instantiate(halberdPrefab);
                halberdPrefab.GetComponent<rotateController3>().setPosition(1,cube[i-1].transform.position, i);
            }
        }
        if (count > 5)
            SceneManager.LoadScene("GameScenes3"); // 라운드 2
            
    }

    public int[] GetRandomInt(int length, int min, int max)
    {
        int[] randArray = new int[length];
        bool isSame;

        for (int i = 0; i < length; ++i)
        {
            while (true)
            {
                randArray[i] = Random.Range(min, max);
                isSame = false;

                for (int j = 0; j < i; ++j)
                {
                    if (randArray[j] == randArray[i])
                    {
                        isSame = true;
                        break;
                    }
                }
                if (!isSame) break;
            }
        }
        return randArray;
    }
}
