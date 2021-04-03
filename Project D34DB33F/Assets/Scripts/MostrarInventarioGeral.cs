using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class MostrarInventarioGeral : MonoBehaviour
{
    public InventoryGeral inventario;
    public int espaco_x;
    public int numColuna;
    public int espaco_y;
    public int inicio_x;
    public int inicio_y;

    private List<GameObject> tempItemCache;
    private List<SlotInventario> tempSlotCache;

    public Dictionary<SlotInventario, GameObject> itemsMostrar = new Dictionary<SlotInventario, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        this.tempItemCache = new List<GameObject>();
        this.tempSlotCache = new List<SlotInventario>();
        iniciarMostrar();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        updateMostrar();
    }


    public void iniciarMostrar()
    {
        for (int i = 0; i < inventario.slots.Count; i++)
        {
            var objecto = Instantiate(inventario.slots[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            objecto.GetComponent<RectTransform>().localPosition = terPosicao(i);
            objecto.GetComponentInChildren<TextMeshProUGUI>().text = inventario.slots[i].quantidade.ToString();
            if (objecto == null)
                return;
            this.tempItemCache.Add(objecto);
        }

    }


    private Vector3 terPosicao(int posInv)
    {
        return new Vector3(inicio_x + (espaco_x * (posInv % numColuna)), inicio_y + (-espaco_y * (posInv/numColuna)), 0f);
    }

    public void updateMostrar()
    {

        if (tempSlotCache == null)
        {
            tempSlotCache = inventario.slots;
        }


        if (tempSlotCache != inventario.slots)
        {
            //apagar o inventario anterior
            for (int i = 0; i < tempItemCache.Count; i++)
            {
                Destroy(tempItemCache[i]);
            }
            for (int i = 0; i < inventario.slots.Count; i++)
            {
                var objecto = Instantiate(inventario.slots[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
                objecto.GetComponent<RectTransform>().localPosition = terPosicao(i);
                objecto.GetComponentInChildren<TextMeshProUGUI>().text = inventario.slots[i].quantidade.ToString();
            }

            tempSlotCache = inventario.slots;
        }
    }


}
