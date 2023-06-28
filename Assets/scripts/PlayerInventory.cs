using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfObjects { get; private set; }

    public void ObjectCollected()
    {
        NumberOfObjects++;
    }
}
