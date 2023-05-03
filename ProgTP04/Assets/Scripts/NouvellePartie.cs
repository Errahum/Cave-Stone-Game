using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NouvellePartie : MonoBehaviour
{
    private void Start()
    {
        //remet la difficult� � 0
        StateNameController.difficulty -= StateNameController.difficulty;
    }

    //la difficulter facile
    public void Facile()
    {
        SceneManager.LoadScene("TP04");
        //rajoute de la difficult�
        StateNameController.difficulty += 7;
    }
    //la difficulter normale
    public void Normal()
    {
        SceneManager.LoadScene("TP04");
        //rajoute de la difficult�
        StateNameController.difficulty += 10;
    }
    //Retoutner au menu principale
    public void RetourMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }

    //quitt� l'application
    public void Quitter()
    {
        Application.Quit();

    }
}
