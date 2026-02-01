using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip musicClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
