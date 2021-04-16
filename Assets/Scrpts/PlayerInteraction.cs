using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public ObjectInteraction currentInterObjScrpit = null;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj == true)
        {
            if (currentInterObjScrpit.info == true)
            {
                currentInterObjScrpit.Info();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj == true)
        {
            if(currentInterObjScrpit.pickup == true)
            {
                currentInterObjScrpit.Pickup();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj == true)
        {
            if (currentInterObjScrpit.talks == true)
            {
                currentInterObjScrpit.Talks();
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("InterObjects")== true)
        {
            currentInterObj = other.gameObject;
            currentInterObjScrpit = currentInterObj.GetComponent<ObjectInteraction>();
         
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObjects") == true)
        {
            currentInterObj = null;
        }
    }
}
