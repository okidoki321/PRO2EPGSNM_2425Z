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

            //czeck  if exist data serializer.anysave()
            // if exist a activetae cintinur button   
            // else deactive
        }
    }
    public void NewGame()
    {
        new SaveData();

    }
    
    public void Continue()
    {
        if (DataSerializer.AnySaves())
        {
            DataSerializer.Load();
            playerMovement.Load();
        }

    }
    public void exit()
    {

        
    }
    public void save()
    {
        //fill save data

        playerMovement.Save();
        DataSerializer.Save();

    }
}

