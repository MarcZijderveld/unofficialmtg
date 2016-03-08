using UnityEngine;
using System.Collections;

[System.Serializable]
public class Card
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

    public string layout;
    public string name;
    public string[] names;
    public string manaCost;
    public float cmc;
    public string[] colors;
    public string type;
    public string[] supertypes;
    public string[] types;
    public string[] subtypes;
    public string rarity;
    public string text;
    public string flavor;
    public string artist;
    public string number;
    public string power;
    public string toughness;
    public int loyalty;
    public int multiverseid;
    public string[] variations;
    public string imageName;
    public string border;
    public string watermark;
}
