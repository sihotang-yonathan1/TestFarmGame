using Unity.VisualScripting;
using UnityEngine;

public class ItemHighlightScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void HighlightItem(){
        spriteRenderer.color = Color.gray;
    }

    void UnhighlightItem(){
        spriteRenderer.color = Color.white;
    }

    void OnTriggerEnter2D(){
        HighlightItem();
    }

    void OnTriggerExit2D(){
        UnhighlightItem();
    }
}
