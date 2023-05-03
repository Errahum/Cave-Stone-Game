using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Classe qui d�tecte que le joueur a gagn� et charge la sc�ne de victoire
/// 
/// Auteur: �ric Wenaas
/// </summary>
public class ZoneArrivee : MonoBehaviour
{
    /// <summary>
    /// Le joueur qu'on doit replacer
    /// </summary>
    private GameObject joueur;

    void Start()
    {
        joueur = GameObject.Find("Joueur");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            SceneManager.LoadScene("Victoire");
        }
    }
}
