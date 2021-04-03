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

    public enum Tipo
    {
        item,
        empty
    }

    [SerializeField]
    public string nome;

    [SerializeField]
    Rarity raridade;

    [SerializeField]
    Sprite icon;

    [SerializeField]
    public Tipo tipoItem;

    [SerializeField]
    public bool isStackable;

    [SerializeField]
    public GameObject prefab;

    string uID;

}
