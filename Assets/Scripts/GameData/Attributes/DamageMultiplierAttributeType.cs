using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageMultiplierAttribute", menuName = "SO/Attribute/DamageMultiplierAttribute")]
public class DamageMultiplierAttributeType : ProjectileAttributeTypeBase
{
    [SerializeField]
    [Range(0, 10)]
    private float m_DamageMultiplier = 2.0f;
    public float DamageMultiplier { get { return m_DamageMultiplier; } }

    public override ProjectileAttributeBase CreateAttribute()
    {
        return new DamageMultiplierAttribute(this);
    }
}

public class DamageMultiplierAttribute : ProjectileAttributeBase
{
    private DamageMultiplierAttributeType DamageMultiplierData { get => Type as DamageMultiplierAttributeType; }

    public DamageMultiplierAttribute(ProjectileAttributeTypeBase data) : base(data)
    {

    }

    public override float OnCalculateDamage(float baseDamage)
    {
        baseDamage *= DamageMultiplierData.DamageMultiplier;
        return baseDamage;
    }
}