using UnityEngine;
using UnityEngine.UI;
using System;

public class CardDisplay : MonoBehaviour
{
    public CardPrefab[] cards;
    private CardPrefab randomCard;

    public CardDisplay[] CardsInHand;

    public Text cardName;
    public Text description;
    public Text attack;
    public Text hp;
    public Text manaCost;

    public Image art;

    private void Start()
    {
        randomCard = cards[UnityEngine.Random.Range(0,cards.Length)];

        cardName.text = randomCard.cardName;
        description.text = randomCard.description;
        attack.text = randomCard.attack.ToString();
        hp.text = randomCard.hp.ToString();
        manaCost.text = randomCard.manaCost.ToString();
        art.sprite = randomCard.art;
    }
    private void Update()
    {
        CheckHp();
    }
    private void CheckHp() 
    {
        if (Convert.ToInt32(hp.text) < 1)
        {
            Destroy(gameObject);
        }
    }
}
