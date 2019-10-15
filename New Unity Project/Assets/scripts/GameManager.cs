using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject four;

    public GameObject floor;
    public GameObject mainCamera;
    public GameObject level;

    public int sizeX = 10;
    public int sizeZ = 10;

    float xfloat;
    float zfloat;

    private void Start()
    {
        if (sizeX % 2 != 0)
        {
            sizeX = sizeX + 1;
        }
        if (sizeZ % 2 != 0)
        {
            sizeZ = sizeZ + 1;
        }
        xfloat = sizeX;
        zfloat = sizeZ;
        Boarder();

        if(sizeX > sizeZ)
        {
            mainCamera.transform.position = new Vector3(0, xfloat/2f +zfloat/10, 0);
        }
        if(sizeX<sizeZ)
        {
            mainCamera.transform.position = new Vector3(0, zfloat/2f + zfloat/10f, 0);
        }
    }

    public void Boarder()
    {
        floor.transform.localScale = new Vector3(xfloat / 10f, 1f, zfloat / 10f);
        Instantiate(floor, transform.position, Quaternion.identity);

        for (int i = 0; i < sizeX; i++)
        {
            Vector3 pos = new Vector3(i - (sizeX / 2)+ 0.5f, 0.5f, (-sizeZ / 2)+0.5f);
            Vector3 pos2 = new Vector3(i - (sizeX / 2) + 0.5f, 0.5f, (sizeZ / 2)-0.5f);
            Instantiate(one, pos, transform.rotation, level.transform);            
            Instantiate(one, pos2, transform.rotation, level.transform);

        }

        for (int i = 0; i < sizeZ -2; i++)
        {
            Vector3 pos = new Vector3((-sizeX / 2) +0.5f, 0.5f, i - ((sizeZ-2) / 2) + 0.5f);
            Vector3 pos2 = new Vector3((sizeX / 2) - 0.5f, 0.5f, i - ((sizeZ - 2) / 2) + 0.5f);
            Instantiate(one, pos, transform.rotation, level.transform);
            Instantiate(one, pos2, transform.rotation, level.transform);
        }              
    }
}
