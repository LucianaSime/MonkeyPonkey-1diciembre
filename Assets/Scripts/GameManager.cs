using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealthController playerHealthController;
    public int engranajillosDestruidos = 0;
    public Animator jaulillaAnimax;
    public GameObject pausitix;
    public bool IsPause;
    public GameObject howtowinnii;

    private void Start()
    {
        AudioManager.instance.PlayMusic(1);
        pausitix.SetActive(false);
        IsPause = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            IsPause = !IsPause;
            pausitix.SetActive(IsPause);
            DesactivateControllini();
        }
    }

    public void DesactivePause ()
    {
        IsPause = false;
        pausitix.SetActive(false);
        DesactivateControllini();
    }

    public void ActivateControllini()
    {
        howtowinnii.SetActive(true);

    }

    public void DesactivateControllini()
    {
        howtowinnii.SetActive(false);

    }

    public void OnEngranajilloDestruidillo()
    {
        engranajillosDestruidos++;
        if (engranajillosDestruidos == 1)
        {
            jaulillaAnimax.SetBool("IsOpen", true);
        }
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Debug.Log("memori");
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit();
    }
}


