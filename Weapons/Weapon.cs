using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	abstract protected int baseDamage { get; }
	abstract protected int baseRadius { get; }
	abstract protected int baseRange  { get; }
	
	public int damage { get; set; }
	public int radius { get; set; }
	public int range  { get; set; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
