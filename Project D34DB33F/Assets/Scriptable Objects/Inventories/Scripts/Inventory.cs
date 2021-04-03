using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : ScriptableObject
{
    [SerializeField]
    public int maxSlots;

    [SerializeField]
    public int unlockedSlots;

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

    public void adicionarQuantidade(int quantidade)
    {
        if(quantidade + this.quantidade >= this.quantidadeMax)
        {

        }
        else
        {
            this.quantidade += quantidade;
        }

    }

    public void trocarItem(Item item, int quantidade)
    {
        this.item = item;
        this.quantidade = quantidade;
        if(item.isStackable)
        {
            this.slotAceitaStacks = true;
        }
        else
        {
            this.slotAceitaStacks = false;
        }
    }
}
