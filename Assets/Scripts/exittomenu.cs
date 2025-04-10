using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exittomenu : MonoBehaviour
{
    private void Update() // funzione che a ogni frame controlla se...
    {
        if (Input.GetKeyDown(KeyCode.L)) //il Player ha premuto il tasto L e se lo ha fatto...
        {
            SceneManager.LoadSceneAsync(0); //carica la scena numero 0 (in base all'ordine delle Build Scene)
            Cursor.lockState = CursorLockMode.None; //forza la visione e funzione del mouse sullo schermo
            Cursor.visible = true; //forza la visione e funzione del mouse sullo schermo
        }
    }
}
