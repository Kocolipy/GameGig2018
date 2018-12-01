using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Obstacle {

	// Use this for initialization
	void Start () {
        this.DAMAGE = 40;
        this.SLOW_PERCENT = 25f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
