using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    public abstract void Reload();
    public abstract void Press();
    public abstract void Release();
}

