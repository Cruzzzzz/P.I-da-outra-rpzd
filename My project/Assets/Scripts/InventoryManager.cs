using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance; 
    private Dictionary<ItemType, int> inventory = new Dictionary<ItemType, int>();

    [SerializeField] private Text moedaText;
    [SerializeField] private Text chaveText;
    [SerializeField] private Text pocaoVidaText;
    [SerializeField] private Text pocaoManaText;
    [SerializeField] private Text cristalText;
    [SerializeField] private Text pergaminhoText;

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
    }
    private void UpdateUI()
    {
        if (moedaText != null) moedaText.text = inventory[ItemType.Tronco].ToString();
        if (chaveText != null) chaveText.text = inventory[ItemType.Cenoura].ToString();
        if (pocaoVidaText != null) pocaoVidaText.text = inventory[ItemType.Ouro].ToString();
        if (pocaoManaText != null) pocaoManaText.text = inventory[ItemType.Semente].ToString();
        if (cristalText != null) cristalText.text = inventory[ItemType.Cogumelo].ToString();
        if (pergaminhoText != null) pergaminhoText.text = inventory[ItemType.Trigo].ToString();
    }

    public int GetItemCount(ItemType type)
    {
        return inventory.ContainsKey(type) ? inventory[type] : 0;
    }
}
