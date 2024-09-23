using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Level()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ClickRateNow()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=");
   
    }

    public void ExitThisGame()
    {
        Application.Quit();
    }
}
