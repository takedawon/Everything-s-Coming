using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTrigger : MonoBehaviour
{
    public Slider Hp;
    public Text hpText;
    public GameObject gameOver;
    public static bool isLive;
    int maxHp = 250;
    int currentHp = 250;

    void Start()
    {
        isLive = true;
        gameOver.SetActive(false);
    }

    void Update()
    {
        if (isLive == false && Input.GetKeyDown(KeyCode.G)) // 죽었다 + R키를 누른다 조건을 만족하면 
            SceneManager.LoadScene("GameScenes");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "halberd")
        {
            Hp.value -= 50;
            currentHp -= 50;
            hpText.GetComponent<Text>().text = currentHp + "/" + maxHp;
            if (currentHp <= 0)
            {
                isLive = false;
                gameOver.SetActive(true);
            }
            Debug.Log("부딫혔습니다.");
        }
    }
}
