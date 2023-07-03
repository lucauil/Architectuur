using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveTracker : MonoBehaviour
{
    public GameObject finishline;
    Inventory PlayerInventory; playerInventory
    // Start is called before the first frame update
  

    // Update is called once per frame
   void Update()
    {
      if (playerInventory.NumberOfObjects == 3)
       {
            finishline.SetActive(true);
        }
    }
}
