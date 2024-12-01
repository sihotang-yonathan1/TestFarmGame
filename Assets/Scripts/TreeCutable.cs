using UnityEngine;

public class TreeCutable : ToolHit
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Hit()
    {
        Destroy(gameObject);
    }
}
