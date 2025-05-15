using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCondition : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "End";

    private void Start()
    {
        
    }

    public void CheckVictoryCondition()
    {
        foreach (ItemType item in System.Enum.GetValues(typeof(ItemType)))
        {
            if (InventoryManager.Instance.GetItemCount(item) < 5)
            {
                return; 
            }
        }

        Debug.Log("O jogador tem 5 de cada item! Cena será carregada.");
        SceneManager.LoadScene(sceneToLoad);
    }
}