using UnityEngine;

[CreateAssetMenu(fileName ="NewItem",menuName ="Crafting/Item")]
public class CraftingItem : ScriptableObject
{
    [SerializeField] string itemname;
    [SerializeField] Sprite sprite;
    public string GetName(){
        return name;
    }

}
