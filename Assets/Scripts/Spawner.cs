using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Player playerTemplate;

    void Start()
    {
        spawnPlayer(); 
    }

  
    public void spawnPlayer()
    {
        Player playerClone = Instantiate(playerTemplate);

        playerClone.transform.position = transform.position;   

        playerClone.gameObject.SetActive(true);
    }
}
