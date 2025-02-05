using UnityEngine;


public class Item
{
    public enum itemType{
        carrot,
        banana
    }

    public Item(itemType t){
        type = t;
        SetDefaultValues();
    }

    string itemname;
    Sprite sprite;
    itemType type;
    int amount = 0;

    public string GetName(){
        return itemname;
    }
    public void SetName(string s){
        itemname = s;
    }
    public Sprite GetSprite(){
        return sprite;
    }
    public void SetSprite(Sprite a){
        sprite = a;
    }
    public void SetAmount(int x){
        amount+=x;
    }
    public int GetAmount(){
        return amount;
    }

    private void SetDefaultValues(){
        switch(type){
            case itemType.carrot:
                itemname = "Carrot";
                sprite = Resources.Load<Sprite>("Assets/sprites/tile000");
                if (sprite == null)
                {
                    Debug.LogError("Sprite not found: sprites/tile000");
                }
                amount = 1;
                break;
            case itemType.banana:
                itemname = "Banana";
                sprite = Resources.Load<Sprite>("Assets/sprites/tile001");
                if (sprite == null)
                {
                    Debug.LogError("Sprite not found: sprites/tile000");
                }
                amount = 1;
                break;
            default:
                itemname = "unknown";
                break;

        }


        
    }
    

}
