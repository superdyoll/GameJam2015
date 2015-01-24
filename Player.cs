using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float speed = 1;

	void Update () {
		if (Input.GetKey ("w")) {
			if(gameObject.transform.position.y < 50f){
				gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f * speed);
			}
			else{
				gameObject.transform.position = new Vector2(gameObject.transform.position.x, 50f);
			}
		}
		if (Input.GetKey ("a")) {
			if(gameObject.transform.position.x > 0f){
				gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.1f * speed, gameObject.transform.position.y);
			}
			else{
				gameObject.transform.position = new Vector2(0f, gameObject.transform.position.y);
			}
		}
		if (Input.GetKey ("s")) {
			if(gameObject.transform.position.y > 0f){
				gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.1f * speed);
			}
			else{
				gameObject.transform.position = new Vector2(gameObject.transform.position.x, 0f);
			}
		}
		if (Input.GetKey ("d")) {
			if(gameObject.transform.position.x < 50f){
				gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.1f * speed, gameObject.transform.position.y);
			}
			else{
				gameObject.transform.position = new Vector2(50f, gameObject.transform.position.y);
			}
		}
	}
}
