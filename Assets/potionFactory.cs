using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public interface IPotionFactory 
{
    IPotion Create(potionRequrements requrements);
}


//Abstract potion factory
public abstract class AbstractPotionFactory
{
    public abstract IPotion Create(potionRequrements requrements);
}

//potion super factory
public class PotionFactory : IPotionFactory
{
    private readonly IPotionFactory _factory;
    private readonly potionRequrements _requirements;

    public IPotion Create(potionRequrements requrements)
    {
        IPotion potion = new BasicPotion();
        //animal parts
        for(int i = requrements.ratTail; i > 0; i--)
        {
            potion = new AddRT(potion);
        }

        for (int i = requrements.owlEye; i > 0; i--)
        {
            potion = new AddOE(potion);
        }
        //flowers
        for (int i = requrements.lylack; i > 0; i--)
        {
            potion = new AddLylack(potion);
        }

        for (int i = requrements.sunflower; i > 0; i--)
        {
            potion = new AddSun(potion);
        }
        //metal
        for (int i = requrements.silver; i > 0; i--)
        {
            potion = new AddSilver(potion);
        }

        for (int i = requrements.gold; i > 0; i--)
        {
            potion = new AddGold(potion);
        }
        return potion;
    }
}




