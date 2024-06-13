using UnityEngine;

public class TriggerGravity : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D boulderRigidbody;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.name);
        // Check if the object entering the trigger is the player or any other object you want to activate the gravity with
        if (other.CompareTag("Player"))
        {
            // Activate gravity on the boulder
            if (boulderRigidbody != null)
            {
                boulderRigidbody.gravityScale = 5;
                Debug.Log("Trigger activated. Gravity enabled for the boulder.");
            }
            else
            {
                Debug.LogError("Boulder Rigidbody2D is not assigned in the Inspector.");
            }
        }
    }
}
