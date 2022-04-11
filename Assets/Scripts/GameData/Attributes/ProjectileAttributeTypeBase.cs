using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileAttributeTypeBase : ScriptableObject
{
    public List<AttributeCategory> Categories;

    [SerializeField]
    private string m_AttributeName = "Attribute";

    public abstract ProjectileAttributeBase CreateAttribute();
}

public abstract class ProjectileAttributeBase
{
    public ProjectileAttributeTypeBase Type;

    public ProjectileAttributeBase(ProjectileAttributeTypeBase type) 
    {
        Type = type;
    }

    public virtual void OnUpdate(float timeStep) { }

    public virtual Vector2 OnCalculateVelocity(Vector2 baseVelocity) { return baseVelocity; }

    public virtual float OnCalculateDamage(float baseDamage) { return baseDamage; }
}