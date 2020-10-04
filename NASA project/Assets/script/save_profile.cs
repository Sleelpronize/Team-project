using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;

public class save_profile : MonoBehaviour
{
    
    public InputField sleepstart;
    public InputField sleepend;
    string tutorialtext;
    string tutorialtext1;
    public static int sleeptimestart;
    public static int sleeptimestop;

    void Awake()
    {
        tutorialtext = PlayerPrefs.GetString("tutorialtextkeyname22");
        tutorialtext1 = PlayerPrefs.GetString("tutorialtextkeyname33");
        sleepstart.text = tutorialtext;
        sleepend.text = tutorialtext1;

        sleeptimestart = int.Parse(tutorialtext);
        sleeptimestop = int.Parse(tutorialtext1);
        
    }
    public void savethis()
    {
        tutorialtext = sleepstart.text;
        tutorialtext1 = sleepend.text;
        PlayerPrefs.SetString("tutorialtextkeyname22", tutorialtext);
        PlayerPrefs.SetString("tutorialtextkeyname33", tutorialtext1);
        sleeptimestart = int.Parse(tutorialtext);
        sleeptimestop = int.Parse(tutorialtext1);
       
    }
    }
