using UnityEngine;

public class PunchSound : MonoBehaviour
{
    public AudioClip punchSound; // Son à jouer
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // This method will be called by an Animation Event
    public void PlayPunchSound()
    {
        audioSource.PlayOneShot(punchSound);
    }
}
