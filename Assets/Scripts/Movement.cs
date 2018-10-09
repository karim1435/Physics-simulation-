using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
abstract class Movement : MonoBehaviour
{
    public delegate void UpdateUIInfo(float distance,float time,float speed);
    public event UpdateUIInfo OnUpdateUIInfo;

    [SerializeField]
    protected float initialVeloctity;
    [SerializeField]
    protected float initialPosition;
    [SerializeField]
    protected float acceleration;

    protected float speed;
    protected float displacement;
    protected Vector3 startingPosition;
    protected float timer;
    protected float endPosition;
    protected abstract float TimeReached { get; }
    protected virtual void Start()
    {
        InitMovementVariable();
        Debug.Log(TimeReached);
    }

    private void InitMovementVariable()
    {
        startingPosition = new Vector3(initialPosition,0,0);
        speed = initialVeloctity;
        transform.position = startingPosition;
        endPosition = GameController.instance.EndPosition;
        displacement = endPosition - initialPosition;
    }

    protected virtual void Update()
    {
        if(timer <= TimeReached) {
            Move();
        }

    }
    protected virtual void Move()
    {

        timer += Time.deltaTime;
        speed += acceleration * Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);


        if(OnUpdateUIInfo != null)
            OnUpdateUIInfo(transform.position.x,timer,speed);
    }
}

