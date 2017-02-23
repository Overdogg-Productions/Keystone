using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAir : State {

    private const string name = "In Air";

	private PlayerController player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	// Use this for initialization
	// Update is called once per frame
	public override void Update () {
		player.move();
        player.jump();
	}
    public override string ToString() {
        return name;
    }
}