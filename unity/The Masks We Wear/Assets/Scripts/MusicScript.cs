using UnityEngine;

public class MusicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource musicSource;
    public AudioClip musicClip;
    void Start()
    {
        //plays music
        musicSource.clip = musicClip;
        musicSource.loop = true;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
