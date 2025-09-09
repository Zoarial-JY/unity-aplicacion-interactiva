using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
public class UIDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    RectTransform rect;
    Canvas canvas;
    CanvasGroup cg;

    void Awake(){
        rect = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        cg = gameObject.GetComponent<CanvasGroup>();
        if (cg == null) cg = gameObject.AddComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData e){
        cg.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData e){
        rect.anchoredPosition += e.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData e){
        cg.blocksRaycasts = true;
    }
}
