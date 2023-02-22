using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuList : MonoBehaviour
{
    public GameObject menuPrefab; // The prefab for the menu item
    public Transform menuParent; // The parent transform for the menu items
    public ScriptableObject[] scriptableObjects; // The array of scriptable objects to display in the menu
    private int currentItemIndex = 0; // The index of the current item in the menu

    [SerializeField] private int menuMoveBy;

    // Start is called before the first frame update
    void Start()
    {
        // Create the initial menu item
        CreateMenuItem();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the user has pressed the "Down" key
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Increment the current item index
            currentItemIndex++;

            // Check if the current item index is greater than the number of scriptable objects
            if (currentItemIndex >= scriptableObjects.Length)
            {
                // Wrap around to the first item
                currentItemIndex = 0;
            }

            // Create a new menu item
            CreateMenuItem();
        }
    }

    // Creates a new menu item for the current scriptable object
    private void CreateMenuItem()
    {
        // Instantiate the menu item prefab
        GameObject menuItem = Instantiate(menuPrefab, menuParent);

        // Set the name of the menu item to the name of the scriptable object
        menuItem.name = scriptableObjects[currentItemIndex].name;

        // Set the text of the menu item to the name of the scriptable object
        //menuItem.GetComponentInChildren<Text>().text = scriptableObjects[currentItemIndex].name;

        // Set the position of the menu item to be under the most recent item
        if (menuParent.childCount > 1)
        {
            Vector3 lastItemPos = menuParent.GetChild(menuParent.childCount - 2).position;
            menuItem.transform.position = new Vector3(lastItemPos.x, lastItemPos.y - menuItem.GetComponent<RectTransform>().rect.height, lastItemPos.z);
        }
        else
        {
            // If there are no other child items, position the new item at the top of the menu parent
            menuItem.transform.position = menuParent.position;
        }
    }

}

