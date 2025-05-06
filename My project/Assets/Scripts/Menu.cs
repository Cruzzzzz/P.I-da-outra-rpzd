using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public void TpScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
