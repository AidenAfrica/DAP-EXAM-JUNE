using UnityEngine;

public class ParticleSystemAttacher : MonoBehaviour
{
    public GameObject targetObject; // The object to which the particle system will be attached
    public ParticleSystem particleSystemPrefab; // The particle system prefab to attach

    private ParticleSystem currentParticleSystem;

    void Start()
    {
        if (targetObject != null && particleSystemPrefab != null)
        {
            AttachParticleSystem();
        }
        else
        {
            Debug.LogError("Target Object or Particle System Prefab is not assigned.");
        }
    }

    void AttachParticleSystem()
    {
        // Instantiate the particle system and attach it to the target object
        currentParticleSystem = Instantiate(particleSystemPrefab, targetObject.transform);

        // Optionally, set the particle system to follow the target object's position
        currentParticleSystem.transform.localPosition = Vector3.zero; // Local position if you want it at the center
        currentParticleSystem.transform.localRotation = Quaternion.identity; // Reset rotation
    }

    // Optionally, a method to start the particle system
    public void PlayParticleSystem()
    {
        if (currentParticleSystem != null)
        {
            currentParticleSystem.Play();
        }
    }

    // Optionally, a method to stop the particle system
    public void StopParticleSystem()
    {
        if (currentParticleSystem != null)
        {
            currentParticleSystem.Stop();
        }
    }
}
