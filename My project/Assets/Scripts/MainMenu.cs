using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void Jogar()
    {

        SceneManager.LoadScene("Cena principal");

    }   
    public void Opcoes()
    {
        SceneManager.LoadScene("Opcoes");
    }
    public void Creditos()
    {

        SceneManager.LoadScene("Creditos");
    }
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu Do Game");
    }
    public void ExitMenuPlayer()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Experimento()
    {
        SceneManager.LoadScene("Experimento");
    }

}