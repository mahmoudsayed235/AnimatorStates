using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterController : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;

    public Text countdownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        if (currentTime >= 0)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
        }
    }
}
