using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{

    float raycastDistance = 3; //Adjust to suit your use case

	void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // This creates a 'ray' at the Main Camera's Centre Point essentially the centre of the users Screen

        RaycastHit hit; //This creates a Hit which is used to callback the object that was hit by the Raycast

        if (Physics.Raycast(ray, out hit, raycastDistance)) //Actively creates a ray using the above set perameters at the predeterminded distance
        {
            //Item Raycast Detection
            if (hit.collider.CompareTag("Item"))//Checking if the Raycast has hit a collider with the tag of note
            {
                
                if (Input.GetKeyDown(KeyCode.E))//Check if the player has pressed the Interaction button
                {
                    
                }
            }
            else if (hit.collider.CompareTag("Interactable"))
            {
                //Add a different object here if you choose to want more objects to be able to be detected by the Raycast such as doors etc
            }

            else //If nothing at all with an above tag was hit with the Raycast within the specified distance then run this
            {

            }
        }
    }
}