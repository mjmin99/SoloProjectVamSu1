using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemCollector : MonoBehaviour
{
    [SerializeField] 
    private Text actionText;
    private ItemPickUp currentItem;

    private void Start()
    {
        currentItem = null;
        HideActionText();
    }

    private void Update()
    {
        if (currentItem != null && Input.GetKeyDown(KeyCode.E))
        {
            currentItem.PickUp();
            HideActionText();
        }
    }
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.CompareTag("Item")) return;

        float distance = Vector2.Distance(transform.position, collision.transform.position);

        // �ʹ� �� ���¿��� �̻��ϰ� �������� ��� ����
        if (distance > 1.5f) return;

        currentItem = collision.GetComponent<ItemPickUp>();

        if (currentItem != null)
        {
            ShowActionText(currentItem.items.itemName);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            if (currentItem != null && collision.gameObject == currentItem.gameObject)
            {
                currentItem = null;
                HideActionText();
            }
        }
    }

    private void ShowActionText(string itemName)
    {
        actionText.gameObject.SetActive(true);
        actionText.text = $"{itemName} ȹ�� <color=yellow>(E)</color>";
    }

    private void HideActionText()
    {
        actionText.gameObject.SetActive(false);
    }
}
