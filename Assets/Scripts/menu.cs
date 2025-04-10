using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame() // definisce una funzione selezionabile dall'Inspector...
    {
        SceneManager.LoadSceneAsync(1); //...per caricare la scena 1
    }

    public void QuitGame() // definisce una funzione selezionabile dall'Inspector...
    {
        Application.Quit(); //... per uscire dall'applicazione
    }
}
