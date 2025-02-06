using UnityEngine;


public class Item
{
    public enum itemType{
        carrot,
        banana,
        axe
    }
    public enum itemUse{
        material,
        tool
    }

    public Item(itemType t){
        type = t;
        SetDefaultValues();
    }

    string itemname;
    Sprite sprite;
    itemType type;
    itemUse use;
    int amount = 0;
    string tooltipHeader = "";
    string tooltipContent = "";

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
    public string GetTooltipHeader(){
        return tooltipHeader;
    }
    public string GetTooltipContent(){
        return tooltipContent;
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
                tooltipHeader = "carrot";
                tooltipContent = "healthy!!";
                break;
            case itemType.banana:
                itemname = "Banana";
                sprite = Resources.Load<Sprite>("Assets/sprites/tile001");
                if (sprite == null)
                {
                    Debug.LogError("Sprite not found: sprites/tile000");
                }
                amount = 1;
                tooltipHeader = "banana";
                tooltipContent = "yellow!!";
                break;
            case itemType.axe:
                itemname = "Axe";
                sprite = Resources.Load<Sprite>("Assets/sprites/tile017");
                if (sprite == null)
                {
                    Debug.LogError("Sprite not found: Assets/sprites/tile017");
                }
                amount = 1;
                tooltipHeader = "Axe";
                tooltipContent = "Sharp!!";
                break;

            default:
                itemname = "unknown";
                break;

        }


        
    }
    

}
