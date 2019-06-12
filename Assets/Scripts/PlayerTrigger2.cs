using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTrigger2 : MonoBehaviour
{
    public Slider Hp;
    public Text hpText;
    public GameObject gameOver;
    public static bool isLive;
    int maxHp = 200;
    int currentHp = 200;

    void Start()
    {
        isLive = true;
        gameOver.SetActive(false);
    }

    void Update()
    {
        if (isLive == false && Input.GetKeyDown(KeyCode.G)) // 죽었다 + R키를 누른다 조건을 만족하면 
            SceneManager.LoadScene("GameScenes2");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "halberd")
        {
            Hp.value -= 100;
            currentHp -= 100;
            hpText.GetComponent<Text>().text = currentHp + "/" + maxHp;
            Debug.Log("부딫혔습니다.");
            if (currentHp <= 0)
            {
                isLive = false;
                gameOver.SetActive(true);
            }
        }
    }
}
