using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEngine : EngineBase
{
    [SerializeField]
    private float m_AccelerationPerSecond = 1;

    public override void Move(Vector2 inputDirection)
    {
        // saf
    }
}
