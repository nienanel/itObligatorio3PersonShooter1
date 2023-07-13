using System.Collections;
using UnityEngine;


public class PlayerInteraction : MonoBehaviour
{
    public StarterAssets.StarterAssetsInputs starterAssets;

    private void Update()
    {
        Debug.Log("chequeo uodate playerinteraction");
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 1f))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            Debug.Log("raycast detectado");
            if (interactable != null && starterAssets.interact)
            {
                interactable.Interact();
                Debug.Log("Interacción con objeto interactuable");

                StartCoroutine(ResetInteract());
            }         
        }
    }

    private IEnumerator ResetInteract()
    {
        yield return new WaitForSeconds(3f);
;
    }
}

