using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject DialogBoxStart, DialogBoxLevel, DialogBoxOptions, DialogBoxQuit;
    public GameObject DialogBoxNewGame, DialogBoxContinue, DialogBoxCancel;
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DialogBoxStart.SetActive(false);
        DialogBoxLevel.SetActive(false);
        DialogBoxOptions.SetActive(false);
        DialogBoxQuit.SetActive(false);
        DialogBoxNewGame.SetActive(true);
        DialogBoxContinue.SetActive(true);
        DialogBoxCancel.SetActive(true);
    }
    public void Newgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Map"));
    }
    public void CancelGame()
    {
        DialogBoxStart.SetActive(true);
        DialogBoxLevel.SetActive(true);
        DialogBoxOptions.SetActive(true);
        DialogBoxQuit.SetActive(true);
        DialogBoxNewGame.SetActive(false);
        DialogBoxContinue.SetActive(false);
        DialogBoxCancel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
}
