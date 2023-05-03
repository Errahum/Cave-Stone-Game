using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public HUD HUD;

    private void Start()
    {
        //Remettre le mana � 0
        StateNameController.ManaRamasse -= StateNameController.ManaRamasse;
        //Initialis� le mana
        StateNameController.ManaRamasse += 5;
        //Remettre le mana � 0
        StateNameController.ManaTotal -= StateNameController.ManaTotal;
        //Initialis� le mana
        StateNameController.ManaTotal += 5;
    }

    //Ramasser du mana et en gagner 
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            StateNameController.ManaTotal += 1;
            StateNameController.ManaRamasse -= 1;
        }
    }


}
