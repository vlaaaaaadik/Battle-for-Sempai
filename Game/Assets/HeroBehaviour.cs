using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBehaviour : MonoBehaviour
{
    public int Health { get; private set; }
    void Start()
    {
        Health = 3;
        GameObject.Find("health");
        for (int i = 0; i < Health; i++)
        {
            Instantiate(Resources.Load("Components/heart"),);
        }
    }

    void Update()
    {
        
    }
}
