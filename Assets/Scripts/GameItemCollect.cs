using Unity.Collections;
using UnityEngine;

public class GameItemCollect : MonoBehaviour
{
    public int itemCollectedNum = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkCollectibleItem(collision);
    }

    private void checkCollectibleItem(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("GameItem"))
        {
            itemCollectedNum += 1;
            Destroy(collision.gameObject);
        }
    }

}
