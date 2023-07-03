using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI objectText;
     //Start is called before the first frame update
    void Start()
    {
        objectText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateObjectText(PlayerInventory playerInventory)
    {
        objectText.text = playerInventory.NumberOfObjects.ToString();
    }
}
