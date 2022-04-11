using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicProjectileWeapon : WeaponBase
{
    [SerializeField]
    private BasicProjectile m_ProjectilePrefab;

    [SerializeField]
    private float m_ShootInterval = 1.0f;

    private float m_Timer = 0;

    public override void Press()
    {
        // ... Implement pressing logic
        Instantiate(m_ProjectilePrefab);
    }

    public override void Release()
    {
        //
    }

    public override void Reload()
    {
        //
    }
}
