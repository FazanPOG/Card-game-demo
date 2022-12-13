using UnityEngine;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour
{
    public List<CardDisplay> cards;

    public void ChangeHp() 
    {

        for (int i = 0; i < cards.Count; i++) 
        {
            cards[i].hp.text = UnityEngine.Random.Range(-2,9).ToString();

            if (Convert.ToInt32(cards[i].hp.text) < 1) 
            {
                cards.Remove(cards[i]);
            }
        }
    }
    public void ChangeAttack() 
    {
        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].attack.text = UnityEngine.Random.Range(-2, 9).ToString();
        }
    }
    public void ChangeManacost()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].manaCost.text = UnityEngine.Random.Range(-2, 9).ToString();
        }
    }
}
