using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertileSoil : MonoBehaviour {
    public GameObject ThrownSeedsPrefab;

    private bool seedsPlanted = false;
    public bool SeedsPlanted { get { return seedsPlanted; } }
	
    public void PlantSeeds()
    {
        seedsPlanted = true;
        Instantiate(ThrownSeedsPrefab, transform.position, Quaternion.Euler(0f, 0f, 0f), transform);
    }
}
