using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void fromLogin()
    {
        SceneManager.LoadScene(sceneName:"MainScene");
    }
    public void fromIntro()
    {
        SceneManager.LoadScene(sceneName:"login_screen");
    }

   
 
}
