using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    [SerializeField] GameObject pfUI_Item;
    public void AddItemToInventory(Item item){
        for(int i=0;i<transform.childCount;i++){
            if(transform.GetChild(i).GetComponent<InventorySlot>().IsEmpty()){
                GameObject newItem = Instantiate(pfUI_Item,transform.GetChild(i));
                newItem.GetComponent<UI_Item>().SetItem(item);
                break;
            }
        }
    }
}
