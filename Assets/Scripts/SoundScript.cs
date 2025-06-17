using UnityEngine;

public class PunchSound : MonoBehaviour
{
    public AudioClip punchSound; // Son à jouer
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // clic gauche
        {
            // Frappe bras gauche
            PlayPunchSound();
        }

        if (Input.GetMouseButtonDown(1)) // clic droit
        {
            // Frappe bras droit
            PlayPunchSound();
        }
    }

    void PlayPunchSound()
    {
        audioSource.PlayOneShot(punchSound);
    }
}
