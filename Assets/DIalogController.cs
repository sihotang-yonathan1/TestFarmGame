using UnityEngine;

public class DIalogController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject panel;

    void Awake(){
        panel.SetActive(false);
    }

    void OnCollisionEnter2D(){
        panel.SetActive(true);
    }

    void OnCollisionExit2D(){
        panel.SetActive(false);
    }
}
