using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBehaviour : MonoBehaviour
{
    public int Health { get; private set; }
    public int NumOfHearts;
    private GameObject[] Hearts;
    void Start()
    {
        Hearts = GameObject.FindGameObjectsWithTag("health");
        Health = NumOfHearts;
    }
    public void takeDamage()
    {
        Hearts[Health - 1].SetActive(false);
        Health--;
    }
    void Update()
    {
        for (int i = 0; i < NumOfHearts; i++)
        {
            Hearts[i].SetActive(i < Health ? true : false);
        }
        if (!Hearts[0].activeSelf) Instantiate(Resources.Load("Hexagon"));
    }
}
