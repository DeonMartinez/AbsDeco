using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRT : AbstractFactoryDecorator
{
    private float m_potionCost = 5f;
    public AddRT(IPotion potion) : base(potion) { }
    public override float Create()
    {
        return base.Create() + m_potionCost;
    }
}
