using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAccueilScript: MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("salleDeBoxe");
    }
}
