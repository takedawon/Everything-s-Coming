using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTrigger2 : MonoBehaviour
{
    public Slider Hp;
    public Text hpText;
    public 
    int maxHp = 200;
    int currentHp = 200;

    void Update()
    {
        if(currentHp<=0)
        {
            Scene_Manager.gameOver = true;
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "halberd")
        {
            Hp.value -= 100;
            currentHp -= 100;
            hpText.GetComponent<Text>().text = currentHp + "/" + maxHp;
            Debug.Log("부딫혔습니다.");
        }
    }
}
