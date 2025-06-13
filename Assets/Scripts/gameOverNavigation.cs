using UnityEngine;
using UnityEngine.SceneManagement;

public class GameNavigationGameOver : MonoBehaviour
{
    // Nom de la scène d'accueil (pour Rejouer ou Retour au menu)
    public string sceneAccueil = "Accueil";

    // Nom de la scène de boxe (pour Rejouer direct)
    public string salleDeBoxeScene = "SalleDeBoxe";

    // Méthode pour rejouer le match (recharger la salle de boxe)
    public void Rejouer()
    {
        SceneManager.LoadScene(salleDeBoxeScene);
    }

    // Méthode pour revenir à l'accueil
    public void RetourMenu()
    {
        SceneManager.LoadScene(sceneAccueil);
    }

    // Méthode pour quitter le jeu (fonctionne seulement en build, pas dans l'éditeur)
    public void QuitterJeu()
    {
        Application.Quit();
        Debug.Log("Le jeu a quitté."); // Affiche dans la console si on teste dans l'éditeur
    }
}

