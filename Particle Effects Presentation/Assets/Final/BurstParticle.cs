using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstParticle : MonoBehaviour
{
    public GameObject particles;
    public float particleLife;

    public Vector3 mousePosition;

    void Update()
    {
        // Detect Mouse Input
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;
            SpawnParticles(mousePosition, Quaternion.identity);
        }
    }

    // Spawn a particle burst at a location
    void SpawnParticles(Vector3 position, Quaternion rotation)
    {
        GameObject lastCreatedParticle = Instantiate(particles, position, rotation);
        Destroy(lastCreatedParticle, particleLife);
    }
}
