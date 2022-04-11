using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewShipData", menuName = "SO/ShipData")]
public class ShipData : ScriptableObject
{
    [SerializeField]
    private string m_ShipName = "ShipA";

    [SerializeField]
    private Sprite m_PilotPortrait;

    [SerializeField]
    private Ship m_ShipInstancePrefab;
}
