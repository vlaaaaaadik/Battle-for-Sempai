using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    Canvas canvas;
    void Start()
    {
        time = Time.time;
    }
    private bool spawn(int position)
    {
        if (GameObject.Find("Enemy " + position) == null &&
           GameObject.Find("Enemy " + position + "(Clone)") == null)
        {
            Instantiate(Resources.Load("Enemies/Enemy " + position), this.transform);
            return true;
        }
        else
        {
            return false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - time >= 5)
        {
            if(spawn(Convert.ToInt32(UnityEngine.Random.Range(1, 7)))) time = Time.time;
        }
        
    }
}
