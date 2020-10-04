using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class path : MonoBehaviour
{
    int one;
    int one2;
    int one3;
    int one4;
    int one5;
    int one6;
    int one7;
    int sleeptimeend;
    int sleeptimenew;
    int sleepdelay;
    int shiftstart;
    int shiftstop;
    int sleepduration;
    public Text three;
    public Text recomander;
   
    void Update()
    {
         shiftstart = algorithm.shiftstart;
         shiftstop = algorithm.shiftstop;
         sleepduration = algorithm.sleepduration;
        sleeptimeend = algorithm.sleeptimeend;
        sleepdelay = algorithm.sleepdelay;
        sleeptimenew = algorithm.sleeptimenew;
        if(shiftstart-3>24 || shiftstart-3< 0)
        {
            if (shiftstart - 3 > 24)
            {
                one = (shiftstart - 3) - 24;
            } 
           else 
            {
                one = (shiftstart - 3) + 24;
            }

        }
        else
        {
            one = (shiftstart - 3);
        }
        
        if(shiftstart - 2 >24 || shiftstart-2 < 0)
        {
            if (shiftstart - 2 > 24)
            {
                one2 = (shiftstart - 2) - 24;
            } 
           else 
            {
                one2 = (shiftstart - 2) + 24;
            }

        }
        else
        {
            one2 = (shiftstart - 3);
        }


        if (shiftstart - 1 > 24 || shiftstart -1 < 0)
        {
            if (shiftstart - 1 > 24)
            {
                one3 = (shiftstart - 1) - 24;
            }
            else
            {
                one3 = (shiftstart - 1) + 24;
            }

        }
        else
        {
            one3 = (shiftstart - 1);
        }

        if (shiftstart + 4 > 24 || shiftstart + 4 < 0)
        {
            if (shiftstart + 4 > 24)
            {
                one4 = (shiftstart + 4) - 24;
            }
            else
            {
                one4 = (shiftstart +4) + 24;
            }

        }
        else
        {
            one4 = (shiftstart + 4);
        }

        if (shiftstart -(8+sleepduration)> 24 || shiftstart - (8 + sleepduration) < 0)
        {
            if (shiftstart - (8 + sleepduration) > 24)
            {
                one5 = shiftstart - (8 + sleepduration) -24;
            }
            else
            {
                one5 = shiftstart - (8 + sleepduration) + 24;
            }

        }
        else
        {
            one5 = shiftstart - (8 + sleepduration) ;
        }

        if (shiftstart - (6 + sleepduration) > 24 || shiftstart - (6 + sleepduration) < 0)
        {
            if (shiftstart - (6 + sleepduration) > 24)
            {
                one6 = shiftstart - (6 + sleepduration) - 24;
            }
            else
            {
                one6 = shiftstart - (6 + sleepduration) + 24;
            }

        }
        else
        {
            one7 = shiftstart - (6 + sleepduration);
        }

        if (shiftstart - (3 + sleepduration) > 24 || shiftstart - (3 + sleepduration) < 0)
        {
            if (shiftstart - (3 + sleepduration) > 24)
            {
                one7 = shiftstart - (3 + sleepduration) - 24;
            }
            else
            {
                one7 = shiftstart - (3 + sleepduration) + 24;
            }

        }

        else
        {
            one7 = shiftstart - (3 + sleepduration);
        }








        three.text ="WAKE:---"+one.ToString()+"\n EXERSISE for 1 hour:--- "+one2.ToString() + "\n BREAKFAST:--- "+one3.ToString() + "\n SHIFT START:---"+ shiftstart.ToString()+"\n LUNCH:---"+one4.ToString() + "\n SHIFT END:---"+shiftstop.ToString()+"\n EXERSISE for 1 hour and a half"+one5.ToString() + "\n DINNER:--- "+one6.ToString() + "\n SLEEP--- "+one7.ToString();
        recomander.text = "two days earlier from launch date \n sleep time----- " + sleeptimenew.ToString() + "--" + sleeptimeend.ToString() + "\n one days earlier from launch date \n sleep time----- " + sleeptimenew.ToString() + "--" + sleeptimeend.ToString();
    }


}
