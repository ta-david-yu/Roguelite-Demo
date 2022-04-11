using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BasicProjectile : MonoBehaviour
{
    [SerializeField]
    private float m_BaseDamage = 1;

    public UnityEvent OnHit;

    private List<ProjectileAttributeBase> m_Attributes = new List<ProjectileAttributeBase>();


    public enum AddAttributeResult
    {
        Added,
        NotAddedBecauseDuplicate,
        NotAddedBecauseOfExclusion
    }
    public AddAttributeResult TryAddAttribute(ProjectileAttributeTypeBase attributeType)
    {
        foreach (var category in attributeType.Categories)
        {
            var attributeResult = TryGetAttributeOfCategory(category);
            if (attributeResult.Success)
            {
                return AddAttributeResult.NotAddedBecauseDuplicate;
            }
        }

        var attributeInstance = attributeType.CreateAttribute();
        m_Attributes.Add(attributeInstance);
        return AddAttributeResult.Added;
    }

    public void RemoveAttribute(ProjectileAttributeTypeBase attributeType)
    {
        for (int i = m_Attributes.Count - 1; i >= 0; i--)
        {
            var attribute = m_Attributes[i];
            if (attribute.Type == attributeType)
            {
                m_Attributes.RemoveAt(i);
            }
        }
    }

    public struct GetAttributeResult
    {
        public bool Success;
        public ProjectileAttributeBase Attribute;
    }
    public GetAttributeResult TryGetAttributeOfCategory(AttributeCategory category)
    {
        foreach (var attribute in m_Attributes)
        {
            if (attribute.Type.Categories.Contains(category))
            {
                return new GetAttributeResult() { Success = true, Attribute = attribute };
            }
        }
        return new GetAttributeResult();
    }

    private void FixedUpdate()
    {
        // ...Move transform / rigidbody

        foreach (var attribute in m_Attributes)
        {
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Hit aiofjpawjfpawojf
        // 1. Check if it's a damageable target
        // 2. Calcualte damage
        float damage = GetCalculatedDamage();
        // 3. Actually apply the final damage

        OnHit?.Invoke();
    }

    public float GetCalculatedDamage()
    {
        float finalDamage = m_BaseDamage;
        foreach (var attribute in m_Attributes)
        {
            finalDamage = attribute.OnCalculateDamage(finalDamage);
        }
        return finalDamage;
    }
}
