using UnityEngine;
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardPrefab : ScriptableObject
{
    public int manaCost;
    public int attack;
    public int hp;

    public Sprite art;

    public string description;
    public string cardName;
}
