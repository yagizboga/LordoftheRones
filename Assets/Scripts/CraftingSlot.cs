using UnityEngine;

public class CraftingSlot : MonoBehaviour
{
    Item childItem;
    int currentChildCount;

    void Awake(){
        currentChildCount = transform.childCount;
    }

    void Update(){
        if(currentChildCount != transform.childCount && transform.childCount != 0){
            childItem = transform.GetChild(0).GetComponent<Item>();
        }
    }
}
