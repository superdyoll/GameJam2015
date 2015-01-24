using System;
using UnityEngine;
using System.Collections;

public class Diplodofortress : Dino {


	protected override int baseHealth        { get { return 10; } }
	protected override int baseSpeed         { get { return 2;  } }
	protected override int baseSurvivability { get { return 6;  } }
	protected override int baseExplosive     { get { return 4;  } }
	protected override int baseExp           { get { return 2;  } }

	// Use this for initialization
	protected override void Start () {



	}
	
	// Update is called once per frame
	protected override void Update () {
	
	}
}
