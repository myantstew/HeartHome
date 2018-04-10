﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour {
    public GameObject DetectedItem;
    [SerializeField] GameObject DownAperature;  // The "front" of the player.  For use in using items at correct location
    [SerializeField] GameObject RightAperature;  // The "front" of the player.  For use in using items at correct location
    [SerializeField] GameObject LeftAperature;  // The "front" of the player.  For use in using items at correct location
    [SerializeField] GameObject UpAperature;  // The "front" of the player.  For use in using items at correct location

    public GameObject DirectionAperature { get { return GetDirection(); } }

    CharacterMovement Movement;

	// Use this for initialization
	void Awake () {
        Movement = GetComponent<CharacterMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		CheckForAction();
	}

	void CheckForAction() {
        if(Input.GetButtonDown("Action"))
        {
			if (DetectedItem == null) {
                if(Inventory.Current.SelectedIventoryItem != null)
                {
                    Inventory.Current.SelectedIventoryItem.UseAt(DirectionAperature);
                }
                return;
			}

			var item = DetectedItem.GetComponent<IItem>();
			if (item == null) {
				return;
			}

            Inventory.Current.AddInventory(DetectedItem.GetComponent<IItem>());
        }		
	}

    GameObject GetDirection()
    {
        GameObject Aperature = null;
        switch (Movement.Direction)
        {
            case FacingDirection.Up:
                Aperature = UpAperature;
                break;
            case FacingDirection.Down:
                Aperature = DownAperature;
                break;
            case FacingDirection.Left:
                Aperature = LeftAperature;
                break;
            case FacingDirection.Right:
                Aperature = RightAperature;
                break;
            default:
                Aperature = DownAperature;
                break;
        }

        return Aperature;
    }

	void OnTriggerEnter2D(Collider2D collider) {
		this.DetectedItem = collider.gameObject;	
	}

	void OnTriggerExit2D(Collider2D collider) {
		this.DetectedItem = null;	
	}	
}
