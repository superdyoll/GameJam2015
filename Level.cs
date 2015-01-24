using UnityEngine;
using System.Collections;

public static class Level{

	private static int level = 0;

	public static int GetLevel (){
		return level;
	}

	public static void SetLevel (int newLevel){
		level = newLevel;
	}

	public static void IncreaseLevel(){
		level ++;
	}

	public static void IncreaseLevel(int increaseAmount){
		level = level + increaseAmount;
	}
}
