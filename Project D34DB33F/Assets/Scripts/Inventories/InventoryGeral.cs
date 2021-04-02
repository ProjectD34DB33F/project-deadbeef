using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Novo Inventario Geral", menuName = "Inventario/Geral")]
public class InventoryGeral : Inventory
{

    private void Awake()
    {
        List<Item> items = new List<Item>();
    }

}
