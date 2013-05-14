using UnityEngine;
using System.Collections;

public class PlayerCard : MonoBehaviour{
	
	//card stats assigned in inspector for now
	
	//card chi level
	//starts at 1 and is leveled up
	public int level = 1;
	
	//public string name = "card";
	
	//the three attack styles
	public int attack_1 = 1;
	public int attack_2 = 2;
	public int attack_3 = 3;
	
	
	//the three defense styles
	public int defend_1 = 1;
	public int defend_2 = 2;
	public int defend_3 = 3;
	
	
	//the three meditate styles
	public int meditate_1 = 1;
	public int meditate_2 = 2;
	public int meditate_3 = 3;
	
	
	//health stamina and stamina regen rate
	public int health = 50;
	public int maxStamina = 50;
	public int stamRegen = 3;
	
	
	// Use this for initialization
	/*public PlayerCard(int att1, int att2, int att3, int def1, int def2, int def3, int med1, int med2, int med3, int health, int StamMax, int stamRG, string name) {
		attack_1 = att1;
		attack_2 = att2;
		attack_3 = att3;
		defend_1 = def1;
		defend_2 = def2;
		defend_3 = def3;
		meditate_1 = med1;
		meditate_2 = med2;
		meditate_3 = med3;
		this.health = health;
		maxStamina = StamMax;
		stamRegen = stamRG;
		this.name = name;
	}*/
	
	
	
}
