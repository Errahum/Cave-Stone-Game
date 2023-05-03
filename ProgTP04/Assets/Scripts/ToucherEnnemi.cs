using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucherEnnemi : MonoBehaviour
{
    
   
    //Condition pour détruire l'ennemie
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ennemi")
        {
            
            print("-1 Squeleton");
            // -1 Emmemies HUD
            Destroy(collision.gameObject);

            
        }
        Destroy(gameObject);
    }
}
