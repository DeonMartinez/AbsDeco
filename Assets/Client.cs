using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Client : MonoBehaviour
{
    //add button functions

    public int ratTail = 0;
    public int owlEye = 0;
    public int lylack = 0;
    public int sunflower = 0;
    public int silver = 0;
    public int gold = 0;

    public Text CostText;
    //public Text HealthOutput;
    //public Text ManaOutput;
    //public Text ToxcisityOutput;

    public void AddRatTail()
    {
        ratTail++;
    }

    public void AddOwlEye()
    {
        owlEye++;
    }

    public void AddLylack()
    {
        lylack++;
    }

    public void AddSunflower()
    {
        sunflower++;
    }

    public void AddSilver()
    {
        silver++;
    }

    public void AddGold()
    {
        gold++;
    }

    public void Brew()
    {
        float holder;
        potionRequrements requrements = new potionRequrements();

        //set the new requrements that will be passed int the factory to the current local values
        requrements.ratTail = ratTail;
        requrements.owlEye = owlEye;
        requrements.lylack = lylack;
        requrements.sunflower = sunflower;
        requrements.silver = silver;
        requrements.gold = gold;

        IPotion potion = new BasicPotion();

        PotionFactory factory = new PotionFactory();
        potion = factory.Create(requrements);

        holder = potion.Create();

        CostText.text = holder.ToString();
        
    }
    public void Clear()
    {
        ratTail = 0;
        owlEye = 0;
        lylack = 0;
        sunflower = 0;
        silver = 0;
        gold = 0;
    }

 

}
