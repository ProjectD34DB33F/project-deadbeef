using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : ScriptableObject
{
    [SerializeField]
    protected int maxSlots;

    [SerializeField]
    protected int unlockedSlots;





    protected void displayInventario()
    {

    }
}

[System.Serializable]
public class SlotInventario
{
    //class para definir as slots dos inventarios
    public Item item;
    public int quantidade;
    public int quantidadeMax;
    public bool slotLocked;
    public bool slotAceitaStacks;

    public SlotInventario(int quantidadeMaxima, bool slotIsLocked, bool slotAceitaStacks)
    {
        //constructor
        this.quantidadeMax = quantidadeMaxima;
        this.slotLocked = slotIsLocked;
        this.slotAceitaStacks = slotAceitaStacks;


    }
}
