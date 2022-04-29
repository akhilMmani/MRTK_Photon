using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ObjectSelector : MonoBehaviour
{
    //private GameObject spawnedObject;
    public GameObject[] Models;
    int modelIndex = 0;


    // Start is called before the first frame update
  
    // Update is called once per frame
  
    void ARPlaceObject(int id)
    {
        for (int i = 0; i < Models.Length; i++)
        {
            if (i == id)
            {
                GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
                Destroy(clearUp);
                //spawnedObject = Instantiate(arModels[i], new Vector3(0f, 0f, 0.4f), Quaternion.identity);
                //PhotonNetwork.Instantiate(arModels[i].name, PlacementPose.position, PlacementPose.rotation);
            }
        }


    }
    public void Delete()
    {
        GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
        Destroy(clearUp);
    }
    public void ButtonA()
    {
        modelIndex = 0;
        GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
        Destroy(clearUp);
        PhotonNetwork.Instantiate(Models[0].name, new Vector3(0f, 0.1f, .5f), Quaternion.identity);
    }
    public void ButtonB()
    {
        modelIndex = 1;
        GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
        Destroy(clearUp);
        PhotonNetwork.Instantiate(Models[1].name, new Vector3(0f, 0.1f, .5f), Quaternion.identity);
    }
    public void ButtonC()
    {
        modelIndex = 2;
        GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
        Destroy(clearUp);
        PhotonNetwork.Instantiate(Models[2].name, new Vector3(0f, 0.1f, .5f), Quaternion.identity);
    }
    public void ButtonD()
    {
        modelIndex = 3;
        GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
        Destroy(clearUp);
        PhotonNetwork.Instantiate(Models[3].name, new Vector3(0f, 0.1f, .5f), Quaternion.identity);
    }
    public void ButtonE()
    {
        modelIndex = 4;
        GameObject clearUp = GameObject.FindGameObjectWithTag("prefabs");
        Destroy(clearUp);
        PhotonNetwork.Instantiate(Models[4].name, new Vector3(0f, 0.1f, .5f), Quaternion.identity);
    }

}
