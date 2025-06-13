using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameNavigationAccueil : MonoBehaviour
{
    [Header("Nom de la scène à charger")]
    public string salleDeBoxeScene = "SalleDeBoxe";

    [Header("Champ InputField pour entrer le nom du joueur")]
    public InputField nomJoueurInput;

    // Méthode appelée par le bouton Play
    public void LancerLaSalleDeBoxe()
    {
        // Vérifie que l'InputField n'est pas vide
        if (nomJoueurInput != null && !string.IsNullOrWhiteSpace(nomJoueurInput.text))
        {
            string nomJoueur = nomJoueurInput.text;

            // Stocke le nom du joueur (PlayerPrefs est un moyen simple)
            PlayerPrefs.SetString("NomJoueur", nomJoueur);

            // Charge la scène de boxe
            SceneManager.LoadScene(salleDeBoxeScene);
        }
        else
        {
            Debug.LogWarning("Veuillez entrer un nom avant de commencer le match !");
        }
    }
}
