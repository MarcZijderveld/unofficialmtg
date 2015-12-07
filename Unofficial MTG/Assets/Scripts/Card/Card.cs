using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{
    public enum CardType
    {
        undefined,
        creature,
        instant,
        sorcery,
        enchantment,
        artifact,
        planeswalker,
        land
    }

    public enum Rarity
    {
        common,
        uncommon,
        rare,
        mythic
    }

    public int multiID { get; set; }
    public string cardName { get; set; }
    public string setName { get; set; }
    public Texture2D texture { get; set; }
    public CardType cardType = CardType.undefined;
    public int power { get; set; }
    public int toughness { get; set; }
    public Rarity ratity = Rarity.common;
}
