using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HomingAttribute", menuName = "SO/Attribute/HomingAttribute")]
public class HomingAttributeType : ProjectileAttributeTypeBase
{
    [SerializeField]
    private float m_HomingRange = 5;
    public float HomingRange { get => m_HomingRange; }

    [SerializeField]
    private float m_HomingTime = 5;
    public float HomingTime { get => m_HomingTime; }

    public override ProjectileAttributeBase CreateAttribute()
    {
        return new HomingAttribute(this);
    }
}

public class HomingAttribute : ProjectileAttributeBase
{
    private HomingAttributeType HomingData { get => Type as HomingAttributeType; }

    private float m_Timer = 0.0f;

    public HomingAttribute(ProjectileAttributeTypeBase data) : base(data)
    {

    }

    public override void OnUpdate(float timeStep)
    {
        m_Timer += timeStep;
    }

    public override Vector2 OnCalculateVelocity(Vector2 baseVelocity)
    {
        // DO homing logic
        // 1. Find enemy
        // 2. Apply velocity to that enemy
        if (m_Timer <= HomingData.HomingTime)
        {
            // DO homing logic
        }
        else
        {

        }

        return baseVelocity;
    }
}