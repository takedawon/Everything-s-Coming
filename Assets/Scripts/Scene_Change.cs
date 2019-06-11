using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("FirstScenes");
    }

    public void ChanageGameScene()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
