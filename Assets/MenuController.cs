using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    float startTime,endTime;
    void OnEnable()
    {
        startTime = Time.time;

    }

    void Update()
    {
        endTime = Time.time;
        if ((endTime - startTime) > 60)
        {
            print("quitting");
            Application.Quit();
        }
    }
}
