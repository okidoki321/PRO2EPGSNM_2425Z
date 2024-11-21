using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menycontrorel : MonoBehaviour
{
    public GameObject menuPanel; 
    public Movement playerMovement;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
           menuPanel.SetActive(!menuPanel.activeSelf);
        }
    }
    public void NewGame()
    {
        new SaveData();

    }
    
    public void Continue()
    {
        //fill save data

        playerMovement.Save();
        DataSerializer.Save();

    }
    public void exit()
    {

        
    }
    public void save()
    {

    }
}

