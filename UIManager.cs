using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour

{
    public Text displayDePontos;
    public int pontua��o;
   

    public void UpdatePositiveScore()
    {
        pontua��o += 10;

        displayDePontos.text = "Pontua��o " + pontua��o;
    }

    public void UpdateNegativePoints()
    {
        pontua��o -= 10;

        displayDePontos.text = "Pontua��o " + pontua��o;
    }

}
