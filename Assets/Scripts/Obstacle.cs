﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < getRightOfScreen()- 50)
        {
            Object.Destroy(this);
        }
	}
    // On Collision with any of the players
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            var hit = other.gameObject;
            var health = other.gameObject.GetComponent<Player>();
            health.TakeDamage(100);
            other.gameObject.GetComponent<Player>().slowDown(50f);

        }
    }
    private float getRightOfScreen()
    {
        return Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x;
    }
}
