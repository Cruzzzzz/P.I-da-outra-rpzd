using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory_UI inventory;
    private void Awake()
    {
        inventory = new Inventory_UI(21);

    }
}
