using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff : MonoBehaviour
{

    public GameObject txtToDisplay; // variabile pubblica da poter assegnare al testo
                                    // (il tasto da utilizzare) direttamente dall'inspector         
    private bool PlayerInZone;      // variabile booleana che tiene traccia se il giocatore è nella zona
    public GameObject lightorobj;   // viaribile pubblica da assegnare all'oggetto luce

    private void Start() // funzione che inizializza...
    {

        PlayerInZone = false;  // il valore di PlayerInZone a false              
        txtToDisplay.SetActive(false); // e nasconde il testo
    }

    private void Update() // la funzione controlla ad ogni frame...
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.F)) // se il giocatore nella zona e ha premuto "F" e se  vero allora...    
        {
            lightorobj.SetActive(!lightorobj.activeSelf);  // attiva (o disattiva) l'oggetto "Lightorobj" 
            gameObject.GetComponent<AudioSource>().Play(); // fa partire l'audio dell'AudioSource associato all'oggetto
        }
    }

    private void OnTriggerEnter(Collider other) // funzione chiamata quando un altro oggetto entra nel Trigger
                                                // dell'oggetto a cui viene assegnato lo script 
    {
        if (other.gameObject.tag == "Player") // se l'oggetto che entra nel Trigger ha il tag player    
        {
            txtToDisplay.SetActive(true); // attiva il testo
            PlayerInZone = true; // imposta PlayerInZone a true (necessario per l'attivazione della funzione precedente)
        }
    }


    private void OnTriggerExit(Collider other) // funzione chiamata quando un altro oggetto entra nel Trigger
                                               // dell'oggetto a cui viene assegnato lo script 
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false; // attiva il testo
            txtToDisplay.SetActive(false); // imposta PlayerInZone a false
        }
    }
}
