using System.Collections; 
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Events;
 
  public class PlayerInventory : MonoBehaviour 
  {     
    public int NumberOfObjects { get; set; }   
    public UnityEvent<PlayerInventory> OnObjectCollected;  

    public void ObjectCollected()
    {     
        NumberOfObjects++;    
        OnObjectCollected.Invoke(this);
    } 
  }