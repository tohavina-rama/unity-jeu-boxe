using UnityEngine;
using UnityEngine.SceneManagement;

public class GameNavigation : MonoBehaviour
{
    // Référence à la scène de la salle de boxe
    public string salleDeBoxeScene = "SalleDeBoxe";
    // Référence à la scène Game Over
    public string gameOverScene = "GameOver";

    // Méthode appelée quand le joueur clique sur "Play"
    public void LancerLaSalleDeBoxe()
    {
        SceneManager.LoadScene(salleDeBoxeScene);
    }

    // Méthode appelée quand le joueur perd/gagne
    public void AllerAuGameOver()
    {
        SceneManager.LoadScene(gameOverScene);
    }
}

