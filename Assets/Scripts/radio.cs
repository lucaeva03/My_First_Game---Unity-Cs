using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class radio : MonoBehaviour
{

    public GameObject txtToDisplay;// variabile pubblica da poter assegnare al testo
                                   // (il tasto da utilizzare) direttamente dall'inspector
    public GameObject txtToDisplay2;// variabile pubblica da poter assegnare al testo
                                    // (il tasto da utilizzare) direttamente dall'inspector
    private bool PlayerInZone; // variabile booleana che tiene traccia se il giocatore è nella zona
    private AudioSource audioSource; // viaribile pubblica da assegnare all'oggetto che emette l'audio

    private void Start() // la funzione inizializza alcune variabili
    {

        PlayerInZone = false; // PlayerInZone false
        txtToDisplay.SetActive(false); // testo disattivato
        txtToDisplay2.SetActive(false); // testo disattivato
        audioSource = GetComponent<AudioSource>(); //crea un riferimento per riprodurre l'audio
    }

    private void Update() // la funzione ad ogni frame controlla...
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.M)) // ...se il giocatore è nella zona e ha premuto "M" e se  vero allora...
        {
            gameObject.GetComponent<AudioSource>().Play(); // avvia l'audio assegnato all'oggetto
        }
        if (PlayerInZone && audioSource.isPlaying && Input.GetKeyDown(KeyCode.N))  // ...se il giocatore è nella zona e ha premuto "N" e se  vero allora...
        {
            audioSource.Stop(); // stoppa l'audio
        }
    }

    private void OnTriggerEnter(Collider other) // funzione chiamata quando un altro oggetto entra nel Trigger
                                                // dell'oggetto a cui viene assegnato lo script 
    {
        if (other.gameObject.tag == "Player") // se l'oggetto che entra nel Trigger ha il tag player 
        {
            txtToDisplay.SetActive(true); // attiva il testo
            txtToDisplay2.SetActive(true); // attiva il testo
            PlayerInZone = true; // imposta PlayerInZone a true (necessario per l'attivazione della funzione precedente)
        }
    }


    private void OnTriggerExit(Collider other)  // funzione chiamata quando un altro oggetto entra nel Trigger
                                                // dell'oggetto a cui viene assegnato lo script   
    {
        if (other.gameObject.tag == "Player") // se l'oggetto che entra nel Trigger ha il tag player
        {
            PlayerInZone = false; // imposta PlayerInZone a false
            txtToDisplay.SetActive(false); // disattiva il testo
            txtToDisplay2.SetActive(false); // disattiva il testo
        }
    }
}