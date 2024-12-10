using UnityEngine;
using UnityEngine.UI;

public class SoundIconController : MonoBehaviour
{
    [SerializeField] private Image currentIcon;
    public Sprite mutedIcon;
    public Sprite soundIcon;
    public AudioSource audioSource;
    public bool isMuted = false;

    void Awake(){
        currentIcon = GetComponent<Image>();
    }

    public void TriggerUpdate(){
        audioSource.mute = isMuted;
        isMuted = !isMuted;
    }
}
