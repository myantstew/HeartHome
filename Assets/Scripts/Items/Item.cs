﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class is intended to be subclassed for specific items if you need to implement custom "use" behaviors 
 * 
 * */
public class Item : MonoBehaviour, IItem {
    public Sprite Icon;

    public Sprite InventoryIcon
    {
        get
        {
            return Icon;
        }
    }

    public virtual void UseAt(GameObject location)
    {
        Debug.Log(name + " does nothing. Used at " + location.name + " location");
    }

    public virtual void UseAt(Vector2 location)
    {
        Debug.Log(name + " does nothing. Used at " + location);
    }
}
