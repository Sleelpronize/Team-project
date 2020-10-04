using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;

public class algorithm : MonoBehaviour
{   public GameObject path1;
    public GameObject path2;
    public GameObject path3;
    public static int sleepduration;
    public static int shiftstart;
    public static int shiftstop;
    public static int sleeptimenew;
    public static int sleeptimeend;
    public static int sleepdelay;
    string regularschedule;
    string delay;
    int beforelaunchtime;
    int afterlaunchtime;
    int date;
    int hour;
    int minitues;
    int launchdate;
    int launchhour;
    int launchduration;
    int travelduration;
    int landingduration;
    int sleeptimestart;
    int sleeptimestop;
    string tutorialtext;
    string tutorialtext1;
    int workduration;
   
    
    

    void Update()

    {
        tutorialtext = PlayerPrefs.GetString("tutorialtextkeyname22");
        tutorialtext1 = PlayerPrefs.GetString("tutorialtextkeyname33");
        sleeptimestart = int.Parse(tutorialtext);
        sleeptimestop = int.Parse(tutorialtext1);

        hour = System.DateTime.Now.Hour;
        minitues = System.DateTime.Now.Minute;
        launchdate = save.launchdate;
        launchhour = save.launchhour;
        launchduration = save.launchduration;
        travelduration = save.travelduration;
        landingduration = save.landingduration;
        shiftstart = save.shiftstart;
        shiftstop = save.shiftstop;
        sleeptimestart = save_profile.sleeptimestart;
        sleeptimestop = save_profile.sleeptimestop;
        if (sleeptimestart < sleeptimestop)
        {
            sleepduration = sleeptimestop - sleeptimestart;
        }
        else
        {
            sleepduration = 24 + (sleeptimestop - sleeptimestart);
        }

        if (shiftstart < shiftstop)
        {
            workduration = shiftstop - shiftstart;
        }
        else
        {
            workduration = 24 + (shiftstop - shiftstart);
        }




        if (sleeptimestart < sleeptimestop)
        {
            if (launchhour > sleeptimestart && launchhour < sleeptimestop)
            {

                beforelaunchtime = launchhour - sleeptimestart;
                afterlaunchtime = sleeptimestop - (launchhour + launchduration);

            }
            else
            {
                if (launchhour < sleeptimestart && launchhour + launchduration > sleeptimestart)
                {
                    beforelaunchtime = launchhour - sleeptimestart;
                    afterlaunchtime = sleeptimestop - (launchhour + launchduration);

                }

                else
                {
                    beforelaunchtime = 9;
                    afterlaunchtime = 10;
                }
            }

        }

        else
        {
            if (launchhour < sleeptimestop)
            {
                afterlaunchtime = sleeptimestop - (launchduration + launchhour);
                beforelaunchtime = (24 - sleeptimestart) + launchhour;


            }
            else
            {
                if (launchhour + launchduration > sleeptimestart)
                {
                    beforelaunchtime = launchhour - sleeptimestart;
                    afterlaunchtime = (sleeptimestart + sleepduration) - (launchhour + launchduration);

                }
                else
                {
                    beforelaunchtime = launchhour + launchduration - sleeptimestart;
                    afterlaunchtime = (sleeptimestart + sleepduration) - (launchhour + launchduration);

                }
            }
        }

        if (beforelaunchtime < sleepduration || afterlaunchtime < sleepduration)
        {
            if (beforelaunchtime > afterlaunchtime)
            {

                sleeptimenew = launchhour - (sleepduration + 2);
                sleepdelay = sleeptimenew - sleeptimestart;
               
            }

            else
            {
                sleeptimenew = launchhour + launchduration;
                sleepdelay = sleeptimenew - sleeptimestart;
                
            }


        }
        else
        {

            sleeptimenew = sleeptimestart;
            delay = "0";
        }
        sleeptimeend = sleeptimenew + sleepduration;
       
        if (sleeptimenew < 0)
        {
            sleeptimenew = sleeptimenew + 24;
        }
        if (sleeptimenew > 24)
        {
            sleeptimenew = sleeptimenew -24;
        }
        if (sleeptimeend < 0)
        {
            sleeptimeend = sleeptimeend + 24;
        }
        if (sleeptimeend >24)
        {
            sleeptimeend = sleeptimeend - 24;
        }
        if (sleepdelay > 24)
        {
            sleepdelay = sleepdelay - 24;
        } 
        if (sleepdelay < -24)
        {
            sleepdelay = sleepdelay + 24;
        }
        delay = sleepdelay.ToString();



        if (sleepdelay > 3)
        {
            path1.SetActive(false);
            path2.SetActive(true);
            path3.SetActive(false);
        } 
        if (sleepdelay < -3)
        {
            path1.SetActive(false);
            path2.SetActive(false);
            path3.SetActive(true);

        }
        if (sleepdelay <= 3 && sleepdelay >=-3)
        {
            path1.SetActive(true);
            path2.SetActive(false);
            path3.SetActive(false);
        }
        



    }
    
}