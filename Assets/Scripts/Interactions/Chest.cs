using UnityEngine;



public class Chest : MonoBehaviour, IInteractable
{
    private bool isInteractable = true;
    public Animation chestAnimation;
    public AudioClip openChestSound;
   

    AudioSource chestSound;

    private void Start()
    {
        chestSound = GetComponent<AudioSource>();
    }

    public void Interact()
    {  
        if (isInteractable && !chestAnimation.isPlaying)
        {
            chestAnimation.Play("ChestAnim");
            chestSound.PlayOneShot(openChestSound, 1);
            Debug.Log("Cofre abierto");

            isInteractable = false;       
        }
    }

}
