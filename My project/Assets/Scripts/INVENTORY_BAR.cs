using UnityEngine;

public class INVENTORY_BAR : MonoBehaviour
{

}
   /*public UI_DOINVENTARIO inventoryData;
    public Slot_UI[] slots;

    void Start()
    {
        UpdateBar();
    }

    public void UpdateBar()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventoryData.slots.Count)
            {
                var slotData = inventoryData.slots[i];
                if (slotData.type != CollectableType.NONE)
                {
                    slots[i].SetSlot(slotData.icon, slotData.count);
                }
                else
                {
                    slots[i].ClearSlot();
                }
            }
            else
            {
                slots[i].ClearSlot();/*
            }
        }
    }
}
/*