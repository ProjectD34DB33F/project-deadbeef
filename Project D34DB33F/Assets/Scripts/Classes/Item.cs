using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    enum Rarity
    {
        Common,
        Uncommon,
        Rare
    }

    [SerializeField]
    string Nome;

    [SerializeField]
    Rarity raridade;

    [SerializeField]
    Sprite icon;

    string uID;

}
