using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public interface IPotion 
{
    float Create();
    
    //float GetHealth();
    //float GetMana();
    //float GetToxicity();

}

public class BasicPotion : IPotion
{
    private float m_BasicCost = 10f;

    public float Create()
    {
        return m_BasicCost;
    }
    //private float m_BasicHealth = 0f;
    //private float m_BasicMana = 0f;
    //private float m_BasicToxicity = 0f;

    //public float GetHealth()
    //{
    //    return m_BasicHealth;
    //}

    //public float GetMana()
    //{
    //    return m_BasicMana;
    //}

    //public float GetToxicity()
    //{
    //    return m_BasicToxicity;
    //}


}

