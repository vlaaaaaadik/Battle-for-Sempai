using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 3;
    public float time = 5;
    private void OnMouseDown()
    {
        health--;
        if (health < 1)
        {
            Destroy(gameObject);

            var score = GameObject.Find("Score").GetComponent<Text>();
            score.text = (Convert.ToInt64(score.text) + 1).ToString();
        }

    }

    private void Start()
    {
        time = Time.time;
    }
    private void Update()
    {
        var heroHealth = GameObject.FindGameObjectsWithTag("health");
        if (Time.time - time >= 5)
        {
            if (heroHealth.Length > 0) Destroy(heroHealth[0]);
            time = Time.time;
        }
    }

}
