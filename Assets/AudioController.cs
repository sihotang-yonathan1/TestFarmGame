using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        audioSource.Play();    
    }
}
