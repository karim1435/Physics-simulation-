using UnityEngine;
using System.Collections;

 class GLBMovement : Movement {

    protected override float TimeReached { get { return displacement / speed; } }
    protected override void Start()
    {
        acceleration = 0;
        base.Start();
    }
}
