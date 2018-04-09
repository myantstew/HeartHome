using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : Item {
    public GameObject FertileSoilPrefab;

    PlayerAction playerAction;
    CharacterMovement playerMovement;

    private void Awake()
    {
        var player = GameObject.Find("Player");
        playerAction = player.GetComponent<PlayerAction>();
        playerMovement = player.GetComponent<CharacterMovement>();

        if(playerAction == null || playerMovement == null)
        {
            Debug.LogError("PlayerAction or CharacterMovement not found in scene.  Hoe needs both to function properly");
        }

    }

    public override void UseAt(GameObject location)
    {
        if(playerAction.DetectedItem == null)
        {
            var soil = Instantiate(FertileSoilPrefab);
            //soil.transform.position = playerMovemen
        }
    }
	
}
