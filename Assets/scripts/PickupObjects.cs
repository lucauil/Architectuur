using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    private void OntriggerEnter(Collider other)
    {
        PlayerInventory PlayerInventory = other.GetComponent<PlayerInventory>();

        if (PlayerInventory != null)
        {
            PlayerInventory.ObjectCollected();
            gameObject.SetActive(false);
        }
    }
}
