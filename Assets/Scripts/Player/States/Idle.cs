using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State {

    public const string name = "Idle";

	private PlayerController player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	public override void Update () {

        player.animator.SetInteger("State", 0);
        player.currentSprintMultiplier = 1;
		player.move();
        player.jump();
        
	}
    public override string ToString() {
        return name;
    } 
}