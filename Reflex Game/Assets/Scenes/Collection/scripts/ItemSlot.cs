using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
   public static bool Checker = false;
   public int SlotID;
   public void OnDrop(PointerEventData eventData)
    {
        DragDrop card = eventData.pointerDrag.GetComponent<DragDrop>();
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if(card.CardID == SlotID)
            {
                Checker = true;
            }
        }
    }
}
