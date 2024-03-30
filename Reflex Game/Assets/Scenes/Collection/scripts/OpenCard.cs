using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public GameObject cardPopup; // ������ �� ����������� ���� � ���������

    void Start()
    {
        cardPopup.SetActive(false); // �������� �������� ����������� ����
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ��������� ������� ����� ������ ����
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject) // ��������� ��������� �� ��������
            {
                cardPopup.SetActive(true); // ���������� ����������� ����
            }
        }
    }
}
