using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewCraftingRecipe",menuName ="Crafting/Recipe")]
public class CraftingRecipe : ScriptableObject
{
    [SerializeField] int gridSize;
    public CraftingItem[,] recipeGrid;
    [SerializeField] CraftingItem result;
    public int GetGridSize(){
        return gridSize;
    }
    public CraftingItem GetResult(){
        return result;
    }
    public CraftingItem GetItemAt(int x,int y){
        if(x<0 || x>=gridSize || y <0 || y >= gridSize){
            return null;
        }
        return recipeGrid[x,y];
    }
    public bool Matches(CraftingItem[,] craftingGrid){
        if(craftingGrid.GetLength(0) != gridSize || craftingGrid.GetLength(1) != gridSize){
            return false;
        }
        for(int x = 0;x<gridSize;x++){
            for(int y=0;y<gridSize;y++){
                if(craftingGrid[x,y] != GetItemAt(x,y)){
                    return false;
                }
            }
        }
        return true;
    }

    void OnEnable(){
        if(recipeGrid == null || recipeGrid.GetLength(0) != gridSize){
            recipeGrid = new CraftingItem[gridSize,gridSize];
        }
    }

}