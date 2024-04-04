using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckAnswers : MonoBehaviour
{
    public void CheckAns()
    {
        Debug.Log(ItemSlot.Checker);
        if (ItemSlot.Checker)
        {
            ButtonClickWin(gameObject);
        }
        else
        {
            ButtonClickFail(gameObject);
        }
    }
    public void ButtonClickWin(GameObject objWin)
    {
        if (ItemSlot.Checker)
        {
            objWin.SetActive(true);
        }
    }
    public void ButtonClickFail(GameObject objFail)
    {

        if (ItemSlot.Checker==false)
        {
            objFail.SetActive(true);
        }
    }
}
