using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    void Start()
    {
        // 🔓 Réactive le temps et débloque la souris
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // 🔁 Fonction pour relancer le jeu
    public void RestartGame()
    {
        SceneManager.LoadScene("salleDeBoxe"); // Remplace si le nom de ta scène est différent
    }
}


