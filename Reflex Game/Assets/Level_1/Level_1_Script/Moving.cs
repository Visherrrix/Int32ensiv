using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    bool move;
    Vector2 mousePos;
    float startPosX;
    float startPosY;

    public GameObject form1;
 
    bool finish;

    private void OnMouseUp()
    {
        move = false;

        if (((Mathf.Abs(this.transform.localPosition.x - form1.transform.localPosition.x))<=5 && (Mathf.Abs(this.transform.localPosition.y - form1.transform.localPosition.y)) <= 5 ))
        { 
            this.transform.position = new Vector2(form1.transform.position.x, form1.transform.position.y);

            finish = true;
        }
        
    }

    void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        move = true;
        mousePos = Input.mousePosition;
        startPosX = mousePos.x - this.transform.localPosition.x ;
        startPosY = mousePos.y - this.transform.localPosition.y;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move) { mousePos = Input.mousePosition;  
            this.gameObject.transform.localPosition = new Vector2((mousePos.x - startPosX)/10, (mousePos.y - startPosY))/10; }

    }
}
