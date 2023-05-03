using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Classe qui barre le curseur de souris. La touche escape permet de la libérer
/// 
/// Auteur: Éric Wenaas et Jeremy Sauro
/// </summary>
public class CursorLock : MonoBehaviour
{

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;


        //Seulement cacher le curseur quand la scene est TP04
        if (sceneName == "TP04")
        {
            Cursor.lockState = CursorLockMode.Locked;

        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
        

        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
