using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 3;
    public float time = 5;
    public HeroBehaviour hero { get; private set; }
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
        hero = GameObject.Find("Hero").GetComponent<HeroBehaviour>();
        time = Time.time;
    }
    private void Update()
    {
        if (Time.time - time >= 5)
        {
            if (hero.Health > 0) hero.takeDamage();
            time = Time.time;
        }
    }

}
