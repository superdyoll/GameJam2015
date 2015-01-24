using UnityEngine;
using System.Collections;

public class DinoAI : MonoBehaviour {
	private Dino dinoStats;
	private Vector2 playerPosition;

	public void InsertBrain (Dino dinoStats) {
		this.dinoStats = dinoStats;
	}

	void Update () {
		/*playerPosition = Level.GetPlayer ().GetPosition ();
		Vector2 currentPosition = new Vector2 (transform.position.x, transform.position.y);
		float distanceToPlayer = Vector2.Distance (playerPosition, currentPosition);

		if(distanceToPlayer > dinoStats.weapon.range){
			Vector2 directionToPlayer = playerPosition - currentPosition;
			directionToPlayer.Normalize ();
			this.transform.position += 0.1f * dinoStats.speed * directionToPlayer;
		}*/
	}
}
