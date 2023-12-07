using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.PlayMusic(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Nivel1");
    }

    public void QuitGame()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }


}
