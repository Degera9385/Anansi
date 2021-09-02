using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour

{
    public Text displayDePontos;
    public int pontuação;
   

    public void UpdatePositiveScore()
    {
        pontuação += 10;

        displayDePontos.text = "Pontuação " + pontuação;
    }

    public void UpdateNegativePoints()
    {
        pontuação -= 10;

        displayDePontos.text = "Pontuação " + pontuação;
    }

}
