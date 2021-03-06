﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventSystem : Singleton<GameEventSystem> {
    [System.Serializable]
    public class GameEvent : UnityEvent { }                     // An Event that does not take an arguments
    [System.Serializable]
    public class GameObjectEvent : UnityEvent<GameObject> { }   // Takes GameObject argument

    public GameEvent MakeGhost;
}
