using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EngineBase : MonoBehaviour
{
    public abstract void Move(Vector2 inputDirection);
}
