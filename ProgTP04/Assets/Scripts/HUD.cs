using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HUD : MonoBehaviour
{
    public Text Mana;
    public Text Ennemies;
    public int EnnemiesTotal = 0;

    private void Start()
    {
        // La difficulté devient les ennemies totale
        EnnemiesTotal = StateNameController.difficulty;
    }
    void Update()
    {


        //HUD
        Mana.text = StateNameController.ManaTotal.ToString("n0");
        Ennemies.text = EnnemiesTotal.ToString();


    }
}
