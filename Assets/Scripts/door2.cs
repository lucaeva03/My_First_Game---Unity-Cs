using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour
{
    public Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("door2", true);
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("door2", false);
        }
    }
}
