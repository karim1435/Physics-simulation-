using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
class GLBBMovement : Movement
{
    protected override float TimeReached
    {
        get {
         
            float s = displacement;
            Debug.Log(s);
            float a = acceleration;
            Debug.Log(a);
            float b = 2 * initialVeloctity;
            Debug.Log(b);
            float c = -2 * s;
            Debug.Log(c);

            return (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
    }
}
