using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AbstractFactoryDecorator : IPotion
{
    protected IPotion newPotion;
    protected IPotion m_DecoratedPotion;
    public AbstractFactoryDecorator(IPotion Potion)
    {
        m_DecoratedPotion = Potion;
    }

    public virtual float Create()
    {
        return m_DecoratedPotion.Create();
    }
}
