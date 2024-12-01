using UnityEngine;

public class PickupItem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Transform PlayerMovement;
    [SerializeField] float speed = 5f;
    [SerializeField] float pickUpDistance = 1.5f;
    [SerializeField] float timeToLive = 10f; // how long the item still appear

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, PlayerMovement.position);
        if (distance > pickUpDistance)
        {
            return;
        }

        transform.localPosition = Vector3.MoveTowards(
            transform.position, PlayerMovement.position, speed * Time.deltaTime);

    }
}
