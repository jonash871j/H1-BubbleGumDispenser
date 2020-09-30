using System;
using System.Collections.Generic;

public static class BubbleGumDispenserStatic
{
    static Random random = new Random();

    static private List<BubbleGum> bubbleGums;
    static private int amount;

    /// <summary>
    /// Used to dispence bubblegum
    /// </summary>
    /// <returns>BubbleGum</returns>
    static public BubbleGum Dispence()
    {
        return DispenceMechanic();
    }

    /// <summary>
    /// Used to fill the bubblegum machine up with more bubblegum
    /// </summary>
    /// <returns>message</returns>
    static public string FillDispencer(int bubbleGumAmount)
    {
        amount = Math.Abs(bubbleGumAmount);

        bubbleGums = new List<BubbleGum>();
        AddBubbleGum(new BubbleGum(BubbleGumTastes.Blueberry, BubbleGumColors.Indigo), 25);
        AddBubbleGum(new BubbleGum(BubbleGumTastes.Blackberry, BubbleGumColors.Purple), 12);
        AddBubbleGum(new BubbleGum(BubbleGumTastes.Truttifrutti, BubbleGumColors.Yellow), 20);
        AddBubbleGum(new BubbleGum(BubbleGumTastes.Orange, BubbleGumColors.Orange), 19);
        AddBubbleGum(new BubbleGum(BubbleGumTastes.Stawberry, BubbleGumColors.Red), 14);
        AddBubbleGum(new BubbleGum(BubbleGumTastes.Apple, BubbleGumColors.Green), 10);

        ShakeMachine();
        RemoveExtraBubbleGums();

        return "The dispenser has been filed up with " + bubbleGumAmount + "bubblegums!";
    }

    // Picks random bubblegum in the dispencer list and then remove- and return it
    static private BubbleGum DispenceMechanic()
    {
        if (amount >= 1)
        {
            int index = random.Next(0, amount);
            amount--;

            BubbleGum bubbleGum = bubbleGums[index];
            bubbleGums.RemoveAt(index);
            return bubbleGum;
        }
        else
            return null;
    }

    // Used to add bubblegums to the dicpencer and specify the amount in procent
    static private void AddBubbleGum(BubbleGum bubbleGum, float procent)
    {
        int loopAmount = (int)(Math.Ceiling((amount / 100.0f) * procent));
        
        for (int i = 0; i < loopAmount; i++)
            bubbleGums.Add(bubbleGum);
    }

    // Used to randomize all the bubblegums in the dispencer
    static private void ShakeMachine()
    {

        for (int i = 0; i < bubbleGums.Count; i++)
        {
            bubbleGums.Insert(random.Next(0, bubbleGums.Count), bubbleGums[i]);
            bubbleGums.RemoveAt(i);
        }
    }

    // Removes the extra bubblegums caused by tolerance spreads
    static private void RemoveExtraBubbleGums()
    {
        while (bubbleGums.Count > amount)
            bubbleGums.RemoveAt(bubbleGums.Count - 1);
        amount = bubbleGums.Count;
    }
}