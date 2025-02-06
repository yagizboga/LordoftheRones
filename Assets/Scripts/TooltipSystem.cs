using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    static TooltipSystem current;
    [SerializeField] Tooltip tooltip;

    void Awake(){
        current = this;
    }

    public static void Show(string headerText,string contentText){
        current.tooltip.SetText(headerText,contentText);
        current.tooltip.gameObject.SetActive(true);
    }

    public static void Hide(){
        current.tooltip.gameObject.SetActive(false);
    }
}
