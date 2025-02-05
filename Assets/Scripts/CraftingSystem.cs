using UnityEngine;

public class CraftingSystem
{
    private Item[,] itemArray;
    private int gridSize = 2;
    public CraftingSystem(){
        itemArray = new Item[gridSize,gridSize];
    }
    private bool IsEmpty(int x,int y){
        if(itemArray[x,y] != null){
            return false;
        }
        return true;
    }
    public Item GetItem(int x,int y){
        return itemArray[x,y];
    }
    public void SetItem(Item item,int x,int y){
        itemArray[x,y] = item;
    }
    private void IncreaseItemAmount(int x,int y){
        itemArray[x,y].SetAmount(1);
    }
    private void DecreaseItemAmount(int x,int y){
        itemArray[x,y].SetAmount(-1);
    }
    private void RemoveItem(int x,int y){
        SetItem(null,x,y);
    }
    public int GetGridSize(){
        return gridSize;
    }
    private bool TryAddItem(Item item,int x,int y){
        if(IsEmpty(x,y)){
            SetItem(item,x,y);
            return true;
        }
        else{
            if(item.GetType() == GetItem(x,y).GetType()){
                IncreaseItemAmount(x,y);
                return true;
            }
            else{
                return false;
            }
            
        }
    }
}
