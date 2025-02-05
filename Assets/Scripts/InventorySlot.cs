using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class InventorySlot : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData){
        if(transform.childCount == 0){
            GameObject dropped = eventData.pointerDrag;
            DraggableObject draggableObject = dropped.GetComponent<DraggableObject>();
            draggableObject.parentAfterDrag = transform;
        }
        else{
            GameObject dropped = eventData.pointerDrag;
            DraggableObject draggableObject = dropped.GetComponent<DraggableObject>();

            GameObject current = transform.GetChild(0).gameObject;
            DraggableObject currentDraggable = current.GetComponent<DraggableObject>();

            currentDraggable.transform.SetParent(draggableObject.parentAfterDrag);
            draggableObject.parentAfterDrag = transform;
        }
        
    }
    public bool IsEmpty(){
        if(transform.childCount == 0){
            return true;
        }
        return false;
    }
}
