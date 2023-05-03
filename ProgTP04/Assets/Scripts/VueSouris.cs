using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script  qui fait gère le déplacement de la caméra avec la souris
/// </summary>
public class VueSouris : MonoBehaviour
{
    /// <summary>
    /// Angle minimum acceptable
    /// </summary>
    [SerializeField] private float angleMinimum;
    /// <summary>
    /// Angle maximum acceptable
    /// </summary>
    [SerializeField] private float angleMaximum;
    /// <summary>
    /// Vitesse de rotation
    /// </summary>
    [SerializeField] private float vitesseRotation;
    /// <summary>
    /// Le jouueur
    /// </summary>
    private GameObject joueur;
    /// <summary>
    /// La rotation en X. On les garde dans une variable pour ne pas avoir à tenir compte de
    /// la façon dont c'est stocké à l'interne. Permet de conserver un angle négatif.
    /// </summary>
    private float rotationX;
    /// <summary>
    /// La rotation en Y.  On les garde dans une variable pour ne pas avoir à tenir compte de
    /// la façon dont c'est stocké à l'interne. Permet de conserver un angle négatif.
    /// </summary>
    private float rotationY;

    void Start()
    {
        joueur = transform.parent.gameObject;

        // On stocke les rotations initiales
        rotationX = joueur.transform.localRotation.eulerAngles.x;
        rotationY = transform.localRotation.eulerAngles.y;
    }

    private void LateUpdate()
    {
        // Rotation sur le joueur
        float horizontal = Input.GetAxis("Mouse X") * Time.deltaTime * vitesseRotation;
        rotationY += horizontal;
        joueur.transform.rotation = Quaternion.Euler(0, rotationY, 0);

        // Rotation sur la caméra
        float vertical = Input.GetAxis("Mouse Y") * Time.deltaTime * vitesseRotation;
        rotationX -= vertical;
        rotationX = Mathf.Clamp(rotationX, angleMinimum, angleMaximum);
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
