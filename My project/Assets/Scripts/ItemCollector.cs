using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private ItemType itemType; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InventoryManager.Instance.AddItem(itemType);
            Destroy(gameObject);
        }
    }
}

// Enum para definir os tipos de itens
public enum ItemType
{
    Tronco, Cenoura, Ouro, Semente, Cogumelo, Trigo
}
