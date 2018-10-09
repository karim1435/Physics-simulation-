using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class TimerManager : MonoBehaviour
{
    [SerializeField]
    private Character objectA;
    [SerializeField]
    private Character objectB;

    public float predictedTime;
    public static TimerManager instance;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else {
            Destroy(this);
        }
    }
    void Start()
    {

        float h = objectA.InitialPos - objectB.InitialPos;

        float a = objectB.Acc - objectA.Acc;
        float b = 2 * (objectB.IntialVel - objectA.IntialVel);
        float c = -2 * h;

        predictedTime = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
    }
 
}
