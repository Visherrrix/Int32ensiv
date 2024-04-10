using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
   public static bool Checker = false;
   public int SlotID;
   static public int k { get; set; }
   static private int id { get; set; }
    public void OnDrop(PointerEventData eventData)
    {
        DragDrop card = eventData.pointerDrag.GetComponent<DragDrop>();
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if(card.CardID == SlotID)
            {
                if(SlotID != id)
                {
                    id = SlotID;
                    Debug.Log(k);
                    if (k == 1)
                    {
                        Checker = true;
                        
                        
                        Debug.Log(k);
                    }
                    //Checker = true;//Эта строчка частично решает баг
                    k = k + 1;
                    Debug.Log(k);
                }
                //Checker = true; //Эта строчка частично решает баг
                
            }
            else
            {
                Debug.Log("NET");
                Checker = false;
            }
            Debug.Log(Checker);
        }
        //else
        //{
        //    if (card.CardID == SlotID && SlotID != 0)
        //    {
        //        k = k - 1;
        //        Checker = false;
        //    }
        //}
    }
}
