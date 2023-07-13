using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class Doors : MonoBehaviour, IInteractable
{
    private bool doorIsOpen = true;
    public Animation doorAnimation;
    public AudioClip openDoorSound;

    AudioSource doorSound;

    private void Start()
    {
        doorSound = GetComponent<AudioSource>();
    }

    private IEnumerator CloseDoorCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (doorIsOpen)
        {
            doorAnimation.Play("closedoor");
            doorIsOpen = false;
            Debug.Log("Puerta cerrada");
        }
    }

    public void Interact()
    {
        if (!doorAnimation.isPlaying)
        {
            doorAnimation.Play("door");
            doorIsOpen = !doorIsOpen;
            Debug.Log(doorIsOpen ? "Abriendo puerta" : "Cerrando puerta");
            doorSound.PlayOneShot(openDoorSound, 1);

            StartCoroutine(CloseDoorCoroutine(3f));

        }
    }

    //public void Interact()
    //{
    //    if (!doorAnimation.isPlaying)
    //    {
    //        if (doorIsOpen)
    //        {
    //            doorAnimation.Play("door");
    //            doorIsOpen = true;
    //            Debug.Log("Abriendo puerta");
    //            doorSound.PlayOneShot(openDoorSound, 1);
    //        }
    //        else
    //        {
    //            doorAnimation.Play("door");
    //            doorIsOpen = true;
    //            Debug.Log("Abriendo puerta");
    //            doorSound.PlayOneShot(openDoorSound, 1);
    //        }

    //        StartCoroutine(CloseDoorCoroutine(3f));

    //    }
    //}
}

