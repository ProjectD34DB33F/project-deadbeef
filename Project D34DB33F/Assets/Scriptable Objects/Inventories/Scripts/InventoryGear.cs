using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Novo Inventario Gear", menuName = "Inventario/Gear")]
public class InventoryGear : Inventory
{
    private void Awake()
    {
        this.maxSlots = 5; //5 slots-> weapon|headArmor|chestArmor|pantArmor|shoes
        List<Item> items = new List<Item>();
    }
}
