using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "SO/ItemData")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private Sprite m_ItemSprite;

    [SerializeField]
    private GameObject m_ItemPickupInstancePrefab;

    // List of attribute to add to when picked up
    [SerializeField]
    private List<ProjectileAttributeTypeBase> m_ProjectileAttributes;
}
