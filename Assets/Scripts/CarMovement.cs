using UnityEngine;
using System.Collections;
using System;

class CarMovement : Movement
{
    [SerializeField]
    private Kid kid;

    protected override float TimeReached
    {
        get {
            float velocity = 0 - initialVeloctity;
            return velocity / (-acceleration);
        }
    }

    protected override void  Start()
    {
        base.Start();
        Vector3 kidPos= new Vector3(displacement,0,0);
        Instantiate(kid,kidPos,Quaternion.identity);
        Debug.Log(TimeReached);
    }
    
}