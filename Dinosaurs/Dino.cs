using System;
using UnityEngine;
using System.Collections;

public abstract class Dino {

	abstract protected int baseHealth        { get; }
	abstract protected int baseSpeed         { get; }
	abstract protected int baseSurvivability { get; }
	abstract protected int baseExplosive     { get; }
	abstract protected int baseExp           { get; }

	public int health { get; set; }
	public int speed { get; set;}
	public int survivability { get; set; }
	public int explosive { get; set; }
	public int exp { get; set; }

	public bool playerControlled{ get; set; }

	int level { get; set; }

	public Dino() {
		playerControlled = false;

		if (!playerControlled) {
			int gameLevel = 1;
		
			System.Random rnd = new System.Random ();
			int rndLevel = rnd.Next (-2, 2);

			int boss = rnd.Next (20);
			if (boss == 13) {
				level = gameLevel + 5;
			}
			else {
				level = gameLevel + rndLevel;
			}
		
			health = (int)Math.Pow (baseHealth, level);
			speed = (int)Math.Pow (baseSpeed, level);
			survivability = (int)Math.Pow (baseSurvivability, level);
			explosive = (int)Math.Pow (baseExplosive, level);
			exp = (int)Math.Pow (baseExp, level);
		} else {
			//Needs to change 'level' with playey.getStat
			health = (int)Math.Pow (baseHealth, level);
			speed = (int)Math.Pow (baseSpeed, level);
			survivability = (int)Math.Pow (baseSurvivability, level);
			explosive = (int)Math.Pow (baseExplosive, level);
			exp = (int)Math.Pow (baseExp, level);
		}
	}

	// Use this for initialization
	abstract protected void Start ();
	
	// Update is called once per frame
	abstract protected void Update ();
}
