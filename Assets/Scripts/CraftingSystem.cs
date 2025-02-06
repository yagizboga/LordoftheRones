using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSystem: MonoBehaviour
{
    const int MAX_CRAFTING_GRID_SIZE = 16;
    Transform [] craftingPanelArray;
    int gridSize = 4;
    GridLayoutGroup gridLayoutGroup;
    
    enum itemRecipe{
        bananawith2carrot,
        carrotwith2banana
    }
    void Awake(){
        craftingPanelArray = new Transform[MAX_CRAFTING_GRID_SIZE];
        gridLayoutGroup = GetComponent<GridLayoutGroup>();
    }

    public void UpdateGridSize(int size){
        gridLayoutGroup.constraintCount = (int)Mathf.Sqrt(size);
        gridSize = size;
        for(int i = 0;i<MAX_CRAFTING_GRID_SIZE;i++){
            craftingPanelArray[i] = transform.Find("CraftingSlot"+ i);
            if(i >= gridSize){
                craftingPanelArray[i].gameObject.SetActive(false);
            }
            Debug.Log(craftingPanelArray[i]);
        }
    }

    public void CheckRecipe(){

    }

}
