using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Inventory inventoryScript;
    float raycastDistance = 5; //Adjust to suit your use case

    void Start()
    {
        inventoryScript = this.GetComponent<Inventory>();
    }
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
                    GameObject item = hit.transform.gameObject;
                    inventoryScript.insertItem(item);
                    Debug.Log("item grabbed");
                    inventoryScript.UpdateUI();
                    Debug.Log("item sotred");
                }
            }

            else //If nothing at all with an above tag was hit with the Raycast within the specified distance then run this
            {

            }
        }
    }
}