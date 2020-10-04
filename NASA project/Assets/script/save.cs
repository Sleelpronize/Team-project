using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class save : MonoBehaviour
{
    
    public InputField launchday;
    public InputField launchday1;
    public InputField launchday2;
    public InputField launchday3;
    public InputField launchday4;
    public InputField launchday5;
    public InputField launchday6;
    string tutorialtext;
    string tutorialtext1;
    string tutorialtext2;
    string tutorialtext3;
    string tutorialtext4;
    string tutorialtext5;
    string tutorialtext6;
   public static int launchdate;
    public static int launchhour;
    public static int launchduration;
    public static int travelduration;
    public static int landingduration;
    public static int shiftstart;
    public static int shiftstop;

    
    void Start()
    {

        tutorialtext = PlayerPrefs.GetString("tutorialtextkeyname");
        tutorialtext1 = PlayerPrefs.GetString("tutorialtextkeyname1");
        tutorialtext2 = PlayerPrefs.GetString("tutorialtextkeyname2");
        tutorialtext3 = PlayerPrefs.GetString("tutorialtextkeyname3");
        tutorialtext4 = PlayerPrefs.GetString("tutorialtextkeyname4");
        tutorialtext5 = PlayerPrefs.GetString("tutorialtextkeyname5");
        tutorialtext6 = PlayerPrefs.GetString("tutorialtextkeyname6");
        
        launchday.text=tutorialtext;
        launchday1.text=tutorialtext1;
        launchday2.text=tutorialtext2;
        launchday3.text=tutorialtext3;
        launchday4.text=tutorialtext4;
        launchday5.text=tutorialtext5;
        launchday6.text=tutorialtext6;
        launchdate = int.Parse(tutorialtext);
        launchhour = int.Parse(tutorialtext1);
        launchduration = int.Parse(tutorialtext2);
        travelduration = int.Parse(tutorialtext3);
        landingduration = int.Parse(tutorialtext4);
        shiftstart = int.Parse(tutorialtext5);
        shiftstop = int.Parse(tutorialtext6);
        
    }
    public void savethis()
    {
        tutorialtext = launchday.text;
        tutorialtext1 = launchday1.text;
        tutorialtext2 = launchday2.text;
        tutorialtext3 = launchday3.text;
        tutorialtext4 = launchday4.text;
        tutorialtext5 = launchday5.text;
        tutorialtext6 = launchday6.text;
        PlayerPrefs.SetString("tutorialtextkeyname", tutorialtext); 
        PlayerPrefs.SetString("tutorialtextkeyname1", tutorialtext1); 
        PlayerPrefs.SetString("tutorialtextkeyname2", tutorialtext2); 
        PlayerPrefs.SetString("tutorialtextkeyname3", tutorialtext3); 
        PlayerPrefs.SetString("tutorialtextkeyname4", tutorialtext4); 
        PlayerPrefs.SetString("tutorialtextkeyname5", tutorialtext5); 
        PlayerPrefs.SetString("tutorialtextkeyname6", tutorialtext);

        launchdate = int.Parse(tutorialtext);
        launchhour = int.Parse(tutorialtext1);
        launchduration = int.Parse(tutorialtext2);
        travelduration = int.Parse(tutorialtext3);
        landingduration = int.Parse(tutorialtext4);
        shiftstart = int.Parse(tutorialtext5);
        shiftstop = int.Parse(tutorialtext6);
        
    }
}
