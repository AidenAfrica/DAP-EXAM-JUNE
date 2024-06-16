using UnityEngine;

public class TriggerToggleImages : MonoBehaviour
{
    public GameObject image1; // Assign this in the Inspector
    public GameObject image2; // Assign this in the Inspector
    public float cooldownTime = 10.0f;
    public string triggerTag = "Player"; // The tag to check for

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger activated by: " + other.name);

            // Deactivate the first image
            
                image1.SetActive(true);
                image2.SetActive(false);


            // Activate the second image


        }
        else {
            image1.SetActive(false);
            image2.SetActive(true);
        }

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
