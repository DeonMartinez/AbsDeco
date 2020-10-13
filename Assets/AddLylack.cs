using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLylack : AbstractFactoryDecorator
{
    private float m_potionCost = 15f;
    public AddLylack(IPotion potion) : base(potion) { }
    public override float Create()
    {
        return base.Create() + m_potionCost;
    }
}