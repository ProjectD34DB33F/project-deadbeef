using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Novo Inventario Cosmetico", menuName = "Inventario/Cosmetico")]
public class InventoryCosmetico : Inventory
{



    private void Awake()
    {
        this.maxSlots = 4; //5 slots-> weapon|headArmor|chestArmor|pantArmor|shoes
        List<Item> items = new List<Item>();
    }
}
