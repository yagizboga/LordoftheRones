using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    string header;
    string content;

    public void OnPointerEnter(PointerEventData eventData){
        TooltipSystem.Show(header,content);
    }

    public void OnPointerExit(PointerEventData eventData){
        TooltipSystem.Hide();
    }

    public void SetText(string h,string c){
        header = h;
        content = c;
    }
}
