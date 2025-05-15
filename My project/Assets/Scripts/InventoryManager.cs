using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;


public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance; 
    private Dictionary<ItemType, int> inventory = new Dictionary<ItemType, int>();

    [SerializeField] private TMP_Text troncoText;
    [SerializeField] private TMP_Text cenouraText;
    [SerializeField] private TMP_Text ouroText;
    [SerializeField] private TMP_Text sementeText;
    [SerializeField] private TMP_Text cogumeloText;
    [SerializeField] private TMP_Text trigoText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        foreach (ItemType item in System.Enum.GetValues(typeof(ItemType)))
        {
            inventory[item] = 0;
        }
        UpdateUI();
    }
    public void AddItem(ItemType type)
    {
        inventory[type]++;
        UpdateUI();
        FindObjectOfType<VictoryCondition>()?.CheckVictoryCondition();
    }
    private void UpdateUI()
    {
        if (troncoText != null) troncoText.text = inventory[ItemType.Tronco].ToString();
        if (cenouraText != null) cenouraText.text = inventory[ItemType.Cenoura].ToString();
        if (ouroText != null) ouroText.text = inventory[ItemType.Ouro].ToString();
        if (sementeText != null) sementeText.text = inventory[ItemType.Semente].ToString();
        if (cogumeloText != null) cogumeloText.text = inventory[ItemType.Cogumelo].ToString();
        if (trigoText != null) trigoText.text = inventory[ItemType.Trigo].ToString();
    }
    public int GetItemCount(ItemType type)
    {
        return inventory.ContainsKey(type) ? inventory[type] : 0;
    }
}
