using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShipList", menuName = "SO/ShipList")]
public class ShipList : ScriptableObject
{
    [SerializeField]
    private List<ShipData> m_ShipData;
}
