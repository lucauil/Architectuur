using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveTracker : MonoBehaviour
{
    public GameObject finishline;
    public PlayerInventory playerInventory;

  

    
   void Update()
    {
      if (playerInventory.NumberOfObjects == 3)
       {
            finishline.SetActive(true);
        }
    }
}
