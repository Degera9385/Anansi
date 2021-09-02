using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //bool timerActive = true;
    float currentTime;
    public int startMinutes;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes*60;
    }

    // Update is called once per frame
    void Update()
    {
      
        currentTime = currentTime - Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = "Tempo:" + time.Minutes.ToString() + ":" + time.Seconds.ToString();

        if(currentTime <=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    
}
