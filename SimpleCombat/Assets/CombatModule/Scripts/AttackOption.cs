using UnityEngine;
using System.Collections;

public enum AttackMethod
{
	Attack,
	Meditation
}

public enum ActionGroup
{
	Group1,
	Group2,
	Group3
}

public class AttackOption {

	public AttackMethod attackMethod; //Attack or Meditation
	public ActionGroup attackGroup; //What Group does this attack belong to?
	public ActionType attackType; //Rock, paper, or scissors
	
	public int basePower; //How much damage to deal or how much endurance to recover
	public int enduranceCost; //How much endurance this options costs
	
	public string attackName; //Name of attack
	public string attackDescription; //Short description of attack
	
	public AttackOption(string attackName, AttackMethod attackMethod, ActionGroup attackGroup, int baseDamage, int enduranceCost, string attackDescription)
	{
		this.attackName = attackName;
		this.attackMethod = attackMethod;
		this.attackGroup = attackGroup;
		this.basePower = baseDamage;
		this.enduranceCost = enduranceCost;
		this.attackDescription = attackDescription;
	}
	
}
