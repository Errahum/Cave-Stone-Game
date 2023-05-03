using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesDie : MonoBehaviour
{
    public HUD HUD;

    //-1 ennemie quand le projectile le touche
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            if(HUD.EnnemiesTotal > 0)
            {
                print("-1 ennemie");
                HUD.EnnemiesTotal -= 1;
            }
            
        }
    }
}
