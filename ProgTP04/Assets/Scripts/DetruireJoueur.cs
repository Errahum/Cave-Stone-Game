using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetruireJoueur : MonoBehaviour
{
    private GameObject joueur;

    // Start is called before the first frame update
    void Start()
    {
        joueur = GameObject.Find("Joueur");
    }
    private void Update()
    {
        //Condition de défaite avec les ennemies et la magie
        if ((StateNameController.difficulty <= 0) || (StateNameController.ManaTotal <= 0 && StateNameController.ManaRamasse == 0))
        {
            SceneManager.LoadScene("Defaite");
        }
    }
    //Condition de défaite avec les ennemies
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            SceneManager.LoadScene("Defaite");
            
        }
    }
}
