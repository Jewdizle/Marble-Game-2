using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject four;

    public int sizeX = 10;
    public int sizeZ = 10;


    // Start is called before the first frame update
    void Start()
    {
        if (sizeX % 2 != 0)
        {
            sizeX = sizeX + 1;
        }
        if (sizeZ % 2 != 0)
        {
            sizeZ = sizeZ + 1;
        }

        Boarder();
    }

    public void LevelSetup()
    {
        
    }

    public void Boarder()
    {
       
        for (int i = 0; i < sizeX; i++)
        {
            Vector3 pos = new Vector3(i - (sizeX / 2)+ 0.5f, 0, (-sizeZ / 2)+0.5f);
            Vector3 pos2 = new Vector3(i - (sizeX / 2) + 0.5f, 0, (sizeZ / 2)-0.5f);
            Instantiate(one, pos, transform.rotation);
            Instantiate(one, pos2, transform.rotation);
        }

        for (int i = 0; i < sizeZ -2; i++)
        {
            Vector3 pos = new Vector3((-sizeX / 2) +0.5f, 0, i - ((sizeZ-2) / 2) + 0.5f);
            Vector3 pos2 = new Vector3((sizeX / 2) - 0.5f, 0, i - ((sizeZ - 2) / 2) + 0.5f);
            Instantiate(one, pos, transform.rotation);
            Instantiate(one, pos2, transform.rotation);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
