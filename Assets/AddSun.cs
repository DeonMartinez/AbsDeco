﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSun : AbstractFactoryDecorator
{
    private float m_potionCost = 10f;
    public AddSun(IPotion potion) : base(potion) { }
    public override float Create()
    {
        return base.Create() + m_potionCost;
    }
}