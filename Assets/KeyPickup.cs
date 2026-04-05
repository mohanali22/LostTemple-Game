using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public static bool hasKey = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasKey = true;
            Destroy(this.gameObject); // ensures ONLY key is destroyed
        }
    }
}