using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Principal : MonoBehaviour
{

    public void PlayRegras()
    {
        SceneManager.LoadScene("Regras");
    }
   public void PlayGame()
    {
        SceneManager.LoadScene("game");
    }

    public void VoltarTelaInicial()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void VerPremiacao()
    {
        SceneManager.LoadScene("Premiação");
    }
}
