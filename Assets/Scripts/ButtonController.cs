using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject menu;

    public void continueClick()
    {
        menu.SetActive(false);
    }
    public void restartClick()
    {
        SceneManager.LoadScene(1);
    }

    public void exitClick()
    {
        Application.Quit();
    }

    public void menuopenClick()
    {
        menu.SetActive(true);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}