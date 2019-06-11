using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTrigger : MonoBehaviour
{
    public Slider Hp;
    public Text hpText;
    public 
    int maxHp = 250;
    int currentHp = 250;

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
            Hp.value -= 50;
            currentHp -= 50;
            hpText.GetComponent<Text>().text = currentHp + "/" + maxHp;
            Debug.Log("부딫혔습니다.");
        }
    }
}
