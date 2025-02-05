using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine.UI;
using UnityEngine;


public class UI_Item : MonoBehaviour
{
    Item item;
    UnityEngine.UI.Image image;

    void Awake(){
        image = GetComponent<UnityEngine.UI.Image>();
    }

    public void SetItem(Item newItem){
        Debug.Log(newItem.GetName());
        if(image == null){
            Debug.Log("Image Cannot Found!");
        }
        image.sprite = newItem.GetSprite();
    }
    public Item GetItem(){
        if(item!=null){
            return item;
        }
        else{
            Debug.LogError("Item is Null! Please Invoke SetItem Function.");
            return null;
        }
        
    }
}
