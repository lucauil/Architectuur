using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeMenu : MonoBehaviour
{
    public GameObject pauzemenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; 
    }
   // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauzemenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauzemenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauzemenu.SetActive(false);
                Cursor.visible = false;

            }
        }
        
    }

    public void stoppen()
    {
        Application.Quit();
    }

    public void verder()
    {
        Time.timeScale = 1f;
        pauzemenu.SetActive(false);
    Cursor.visible = false;
    }

}