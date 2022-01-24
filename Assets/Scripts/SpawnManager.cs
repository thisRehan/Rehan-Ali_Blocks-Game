using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] box;
    public PlayerController player;
    private int spawnStart = 2;
    private int spawnDelay = 5;
    private int index;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("spawn", spawnStart, spawnDelay);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        
        if (!player.gameOver)
        {    
            for (int i = 0; i < box.Length; i++)
            {
                Instantiate(box[i], box[i].transform.position, box[i].transform.rotation);
                box[i].SetActive(true);
            }
            index = Random.Range(0, box.Length);
            box[index].SetActive(false);
        }
       
    }
}
