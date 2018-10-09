using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
class Character : Movement
{
    public float IntialVel { get { return initialVeloctity; } }
    public float InitialPos { get { return initialPosition; } }
    public float Acc { get { return acceleration; } }

    protected override float TimeReached
    {
        get {
            return TimerManager.instance.predictedTime;
        }
    }
}

