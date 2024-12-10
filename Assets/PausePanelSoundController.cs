using UnityEngine;

public class PausePanelSoundController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource audioSource;

    public void PlaySound(){
        audioSource.Play();
    }
}
