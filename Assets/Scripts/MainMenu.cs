using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        PlayerPrefs.SetInt("Player", 0);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitBtn()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void NinjaBtn()
    {
        PlayerPrefs.SetInt("Player", 0);
    }

    public void KnightBtn()
    {
        PlayerPrefs.SetInt("Player", 1);
    }

    public void VampireBtn()
    {
        PlayerPrefs.SetInt("Player", 2);
    }

}
