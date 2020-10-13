using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGold : AbstractFactoryDecorator
{
    private float m_potionCost = 40f;
    public AddGold(IPotion potion) : base(potion) { }
    public override float Create()
    {
        return base.Create() + m_potionCost;
    }
}
