using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class time_show : MonoBehaviour
{
    public GameObject thedisplay;
    public int hour;
    public int minitues;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minitues = System.DateTime.Now.Minute;

        thedisplay.GetComponent<Text>().text = "" + hour + ":" + minitues;
    }
}
