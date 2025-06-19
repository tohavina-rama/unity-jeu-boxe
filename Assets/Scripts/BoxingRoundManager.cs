using UnityEngine;
using UnityEngine.SceneManagement; // ← ajoute ça
using TMPro;

public class BoxingRoundManager : MonoBehaviour
{
    public AudioClip startCloche;
    public AudioClip endCloche;
    public float roundDuration = 20f;

    public TextMeshProUGUI timerText;

    private AudioSource audioSource;
    private float timeLeft;
    private bool roundStarted = false;
    private bool roundEnded = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartRound();
    }

    void Update()
    {
        if (roundStarted && !roundEnded)
        {
            timeLeft -= Time.deltaTime;

            if (timerText != null)
                timerText.text = "Timeleft: " + Mathf.CeilToInt(timeLeft).ToString();

            if (timeLeft <= 0f)
            {
                EndRound();
            }
        }
    }

    void StartRound()
    {
        audioSource.PlayOneShot(startCloche);
        timeLeft = roundDuration;
        roundStarted = true;
    }

    void EndRound()
    {
        roundEnded = true;
        roundStarted = false;
        audioSource.PlayOneShot(endCloche);

        if (timerText != null)
            timerText.text = "Timeleft: 0";

        // Lancer la scène "GameOver" après 2 secondes
       // Invoke("LoadGameOverScene", 2f);
    }

    void LoadGameOverScene()
    {
        Debug.Log("Chargement de la scène GameOver...");
SceneManager.LoadScene("GameOver");

        SceneManager.LoadScene("GameOver");
    }
}
