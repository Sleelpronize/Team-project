using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public void profileScene1()
    {
        SceneManager.LoadScene("profile scene");
    }
    public void sceduleScene2()
    {
        SceneManager.LoadScene("schedule scene");
    } public void main_menu()
    {
        SceneManager.LoadScene("main menu");
    }
    public void seeschedule()
    {
        SceneManager.LoadScene("seeschedule");
    }
     public void exersise()
    {
        SceneManager.LoadScene("exersise");
    }
    public void quitscene()
    {
        Application.Quit();
    }
}
