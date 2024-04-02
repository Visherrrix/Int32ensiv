using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    bool move;
    private Vector3 pointScreen;
    private Vector3 offset;
    //Vector3 mousePos;
    float startPosX;
    float startPosY;
    //Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    public GameObject form1;
 
    bool finish;

    private void OnMouseDown()
    {
        pointScreen = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z));
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
    }
    //private void OnMouseUp()
    //{
    //    move = false;

    //    if (((Mathf.Abs(this.transform.localPosition.x - form1.transform.localPosition.x)) <= 5 && (Mathf.Abs(this.transform.localPosition.y - form1.transform.localPosition.y)) <= 5))
    //    {
    //        this.transform.position = new Vector3(form1.transform.position.x, form1.transform.position.y);

    //        finish = true;
    //    }

    //}

    //void OnMouseDown()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    move = true;
    //    mousePos = Input.mousePosition;
    //    startPosX = mousePos.x - this.transform.localPosition.x ;
    //    startPosY = mousePos.y - this.transform.localPosition.y;
    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (move)
        //{
        //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition,Camera.main.nearClipPlane); ;
        //    this.gameObject.transform.localPosition = mousePos*4;
        //}//new Vector3((mousePos.x - startPosX), (mousePos.y - startPosY)); }

    }
}
