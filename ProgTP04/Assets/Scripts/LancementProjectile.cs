using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancementProjectile : MonoBehaviour
{
    [SerializeField] private GameObject modeleProjectile;
    public HUD HUD;

    


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && (StateNameController.ManaTotal > 0))
        {
            
        

            // Une pretection contre le spam et mana -1
            if (StateNameController.ManaTotal != 0)
        {
            StartCoroutine(AttendreMana());
        }



            //Mana
            GameObject projectile = GameObject.Instantiate(modeleProjectile);
            projectile.transform.position = transform.position + transform.forward * 1.5f;
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 1000 + Vector3.up * 200);
            StartCoroutine(AttendreEtDetruire(projectile));
        }

    }

    private IEnumerator AttendreEtDetruire(GameObject obj)
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(obj);
    }

    //Attendre + mana -1
    public IEnumerator AttendreMana()
    {
        if(StateNameController.ManaTotal >= 0)
            {
                yield return new WaitForSeconds(1.0f);
                StateNameController.ManaTotal -= 1;
                
            }
          
    }
    
}
