using UnityEngine;

public class testing : MonoBehaviour
{
    CraftingSystem craftingSystem;
    UI_Inventory uI_Inventory;
    Item banana;
    Item carrot;
    void Start()
    {
        craftingSystem = GameObject.FindGameObjectWithTag("CraftingPanel").GetComponent<CraftingSystem>();
        uI_Inventory = GameObject.FindGameObjectWithTag("InventoryPanel").GetComponent<UI_Inventory>();
        banana = new Item(Item.itemType.banana);
        carrot = new Item(Item.itemType.carrot);
        craftingSystem.UpdateGridSize(4);

        uI_Inventory.AddItemToInventory(banana);
        uI_Inventory.AddItemToInventory(carrot);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
