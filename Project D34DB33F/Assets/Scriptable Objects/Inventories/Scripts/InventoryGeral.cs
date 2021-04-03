using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Novo Inventario Geral", menuName = "Inventario/Geral")]
public class InventoryGeral : Inventory
{
    [SerializeField]
    public List<SlotInventario> slots;

    [SerializeField]
    KeyCode KeyAddItem;

    private void Awake()
    {
        this.slots = new List<SlotInventario>();


        preencherComEmptyItems();
    }

    private int numeroDeSlotsOcupados()
    {
        SlotInventario tempSlot;
        int slotsOcupados = 0;
        for (int i = 0; i < maxSlots; i++)
        {
            tempSlot = slots[i];
            if (tempSlot.item.tipoItem == Item.Tipo.empty)
            {
                //nao fazer nada, o slot nao esta ocupado
            }
            else if (tempSlot != null)
            {
                slotsOcupados++;
            }
            else
            {
                Debug.Log("Alguma cena correu bue mal, no inventarioGeral chegamos a um valor nulo");
                slotsOcupados = -1;
            }
        }


        return slotsOcupados;
    }

    private void preencherComEmptyItems()
    {
        for (int i = 0; i < this.maxSlots; i++)
        {
            

        }
    }

    public void AdicionarItem(Item item, int quantidade)
    {
        if(numeroDeSlotsOcupados() >= this.maxSlots)
        {
            //ja ta tudo cheio, falta ver é possivel stackar por cima de algum
            if (item.isStackable)
            {
                for (int i = 0; i < this.maxSlots; i++)
                {
                    if (this.slots[i].item.name == item.name)
                    {
                        this.slots[i].adicionarQuantidade(quantidade);
                        break;
                    }
                }
            }
            else
            {
                Debug.Log("Nao é possivel adicionar item, inventario cheio");
            }
        }
        else
        {
            if (item.isStackable)
            {
                //ver se da pa stackar em cima de algum ja no inventario
                for (int i = 0; i < this.maxSlots; i++)
                {
                    if (this.slots[i].item.name == item.name)
                    {
                        this.slots[i].adicionarQuantidade(quantidade);
                        return;
                    }
                }

                //se nao esta ja no inventario vamos trocar por um slot que esteja empty
                for(int i = 0; i < this.maxSlots; i++)
                {
                    //encontrar o proximo slot livre
                    if(this.slots[i].item.tipoItem == Item.Tipo.empty)
                    {
                        this.slots[i].trocarItem(item, quantidade);
                    }
                }
            }

        }
    }

    public void debugger()
    {
        if (Input.GetKey(KeyAddItem))
        {

            Item tempItem = new Item();
            tempItem.isStackable = false;
            tempItem.nome = "aaahhh";
            tempItem.tipoItem = Item.Tipo.item;
            tempItem.prefab = (GameObject)Resources.Load("prefabs/ItemSlotRando");


            Debug.Log("hey\n");
            AdicionarItem(tempItem, 2);
        }
    }

}


