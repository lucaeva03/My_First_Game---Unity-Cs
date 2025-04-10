using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    public Animator myAnimationController; // definisce la varibaile di tipo Animator che contiene
                                           // l'algoritmo delle successioni delle animazioni                                          

    private void OnTriggerEnter(Collider other) // funzione chiamata quando un altro oggetto entra nel Trigger
                                                // dell'oggetto a cui viene assegnato lo script   
    {
        if (other.CompareTag("Player")) // se l'oggetto che entra nel Trigger ha il tag player
        {
            myAnimationController.SetBool("door", true); // allora il parametro booleano "door" dell'animatore diventa true
                                                         // iniziando l'animazione di apertura della porta
            gameObject.GetComponent<AudioSource>().Play(); // fa partire l'audio dell'AudioSource associato all'oggetto
        }
    }

    private void OnTriggerExit(Collider other) // funzione chiamata quando un altro oggetto esce dal Trigger
                                               // dell'oggetto a cui viene assegnato lo script
    {
        if (other.CompareTag("Player")) // se l'oggetto che esce dal Trigger ha il tag player
        {
            myAnimationController.SetBool("door", false); // allora il parametro booleano "door" dell'animatore diventa false
                                                          // riportando l'animazione allo stato di default, 
                                                          // altrimenti continuerebbe all'infinito
        }
    }
}
