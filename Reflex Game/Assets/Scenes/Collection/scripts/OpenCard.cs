using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public GameObject cardPopup; // Ссылка на всплывающее окно с карточкой

    void Start()
    {
        cardPopup.SetActive(false); // Начально скрываем всплывающее окно
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Проверяем нажатие левой кнопки мыши
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject) // Проверяем попадание по карточке
            {
                cardPopup.SetActive(true); // Показываем всплывающее окно
            }
        }
    }
}
