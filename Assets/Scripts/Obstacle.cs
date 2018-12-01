using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    // Use this for initialization
    protected int DAMAGE;
    protected float SLOW_PERCENT;
	void Start () {
        DAMAGE = 100;
        SLOW_PERCENT = 50f;

    }
	
	// Update is called once per frame
	void Update () {
        
	}
    // On Collision with any of the players
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            var hit = other.gameObject;
            var health = other.gameObject.GetComponent<Player>();
            health.TakeDamage(DAMAGE);
            other.gameObject.GetComponent<Player>().slowDown(SLOW_PERCENT);
            

        }
    }
}
