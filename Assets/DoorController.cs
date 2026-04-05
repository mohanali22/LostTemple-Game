using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject winText; // reference to UI text

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && KeyPickup.hasKey)
        {
            winText.SetActive(true); // show text
            Debug.Log("You Win!");
            Destroy(gameObject);
        }
    }
}