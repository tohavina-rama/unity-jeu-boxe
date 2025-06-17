using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameAccueilScript : MonoBehaviour
{
    public InputField prenomInput;

    public void LoadGameScene()
    {
        string prenom = prenomInput.text;

        if (!string.IsNullOrEmpty(prenom))
        {
            PlayerPrefs.SetString("prenom", prenom); // Sauvegarde le prénom
            SceneManager.LoadScene("salleDeBoxe");
        }
        else
        {
            Debug.LogWarning("Le prénom est vide !");
        }
    }
}
