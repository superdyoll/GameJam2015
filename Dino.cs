using System;
using UnityEngine;
using System.Collections;

public abstract class Dino {

	abstract protected int baseHealth        { get; }
	abstract protected int baseSpeed         { get; }
	abstract protected int baseSurvivability { get; }
	abstract protected int baseExplosive     { get; }
	abstract protected int baseExp           { get; }

	int health { get; set; }
	int speed { get; set;}
	int survivability { get; set; }
	int explosive { get; set; }
	int exp { get; set; }

	int level { get; set; }

	public Dino() {
		int gameLevel = 1;
		
		System.Random rnd = new System.Random ();
		int rndLevel = rnd.Next (-2, 2);
		int boss = rnd.Next (20);
		
		level = gameLevel + rndLevel;
		
		health 			= (int) Math.Pow (baseHealth, level);
		speed 			= (int) Math.Pow (baseSpeed, level);
		survivability 	= (int) Math.Pow (baseSurvivability, level);
		explosive 		= (int) Math.Pow (baseExplosive, level);
		exp 			= (int) Math.Pow (baseExp, level);
	}

	// Use this for initialization
	abstract protected void Start ();
	
	// Update is called once per frame
	abstract protected void Update ();
}
