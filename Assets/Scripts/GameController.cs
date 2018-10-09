using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class GameController:MonoBehaviour
{
    public static GameController instance;

    [SerializeField]
    private float endPosition;
    public float EndPosition { get { return endPosition; } }
    void Awake()
    {
        if(instance == null)
            instance = this;
        else {
            Destroy(this);
        }
    }
}

