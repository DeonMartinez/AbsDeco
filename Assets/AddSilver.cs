using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSilver : AbstractFactoryDecorator
{
    private float m_potionCost = 20f;
    public AddSilver(IPotion potion) : base(potion) { }
    public override float Create()
    {
        return base.Create() + m_potionCost;
    }
}