using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Chaque ennemi peut repérer le joueur et donner l'info aux autres ennemis
public class Alert : MonoBehaviour
{
    public static event Action playerSpotted;   //Event de détection du joueur
    public static event Action playerLost;      //Event de "perte" du joueur

    //Ajout des fonctions des ennemis aux events lorsqu'ils deviennent actifs
    private void OnEnable()
    {
        playerSpotted += BecomeHostile;
        playerLost += BecomeDocile;
    }

    //On retire les fonctions des ennemis aux events lorsqu'ils deviennent inactifs
    private void OnDisable()
    {
        playerSpotted -= BecomeHostile;
        playerLost -= BecomeDocile;
    }

    //Quand l'ennemi entre en collision avec le joueur
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerSpotted?.Invoke();    //On invoque la méthode subscribed à l'event pour alerter les autres
        }
    }

    //Quand l'ennemi quitte la collision avec le joueur
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLost?.Invoke();   //On invoque la méthode
        }
    }

    //Change la couleur des ennemis
    public void BecomeHostile()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    public void BecomeDocile()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
