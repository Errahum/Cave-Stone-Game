using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorte : MonoBehaviour
{
    public HUD HUD;
    public GameObject OuvertureVictoire;



    //condition d'ouverture menant à la victoire
    void Update()
    {
        if (HUD.EnnemiesTotal <= 0)
        {
            Destroy(OuvertureVictoire);
            print("La porte de la victoire s'ouvre...");
        }
    }
}
