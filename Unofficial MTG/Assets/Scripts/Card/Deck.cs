using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Deck : MonoBehaviour
{
    public List<Card> mainBoard = new List<Card>();
    public List<Card> sideBiard = new List<Card>();
}
