using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject[] hotbar = new GameObject[5];

    // Start is called when Inventory is called
    void Start()
    {
        
    }

    public void insertItem(GameObject objectInsert)
    { 
        for(int i = 0; i < hotbar.Length; i++)
        {
            if(hotbar[i] == null)
            {
                GameObject itemCopy = Instantiate(objectInsert, transform.position, transform.rotation);
                itemCopy.SetActive(false);
                hotbar[i] = itemCopy;
                Destroy(objectInsert);
                break;
            }
            else 
            {
                Debug.Log("Slot full");
            }
        }
    }
    
    // Update when item added/removed
    public void UpdateUI()
    {
        Debug.Log("ui updated for inventory");
    }
}
