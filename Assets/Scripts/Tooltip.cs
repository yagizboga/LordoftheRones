using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI header;
    [SerializeField] TextMeshProUGUI content;
    [SerializeField] LayoutElement layoutElement;
    [SerializeField] int characterWrapLimit;
    RectTransform rectTransform;

    void Awake(){
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetText(string headerText, string contentText){

        if (header == null || content == null || layoutElement == null){
        Debug.LogError("Tooltip references are not set! Check the Tooltip component in the Inspector.");
        return;
        }
        header.text = headerText;
        content.text = contentText;

        int headerLength = header.text.Length;
        int contentLength = content.text.Length;

        layoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;
    }

    void Update(){
        Vector2 mousePosition = Input.mousePosition;
        float pivotX = (mousePosition.x > Screen.width / 2) ? 1f : 0f;
        float pivotY = (mousePosition.y > Screen.height / 2) ? 1f : 0f;

        rectTransform.pivot = new Vector2(pivotX,pivotY);
        transform.position = mousePosition;
    }
    

}
