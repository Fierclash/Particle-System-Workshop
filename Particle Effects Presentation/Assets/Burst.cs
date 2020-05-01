using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *  Creates a burst particle effect on click at the mouse
 */
public class Burst : MonoBehaviour
{
    public GameObject particles;            // System to spawn
    public float particleLife;              // How long the particles are in the scene

    private Vector3 mousePosition;          // Mouse Position in World Space

    // Update is called once per frame
    void Update()
    {
        // Detects Mouse Input
        if(Input.GetMouseButtonDown(0))
        {
            // Calculate Mouse Position to World Position
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;       // Shift z position in front of camera

            // Spawn Particle
            SpawnParticles(mousePosition, Quaternion.identity);
        }
    }

    // Spawn Particle Burst Effect
    // Destroys object after a few seconds
    void SpawnParticles(Vector3 position, Quaternion rotation)
    {
        GameObject lastParticle = Instantiate(particles, position, rotation);
        Destroy(lastParticle, particleLife);
    }
}
