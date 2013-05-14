using UnityEngine;
using System.Collections;

public class DefendOption {

	public ActionGroup defendGroup;
	public ActionType defendType;
	
	public int baseDefense;
	public int enduranceCost;
	
	public string defendName;
	public string defendDescription;
	
	
	public DefendOption(string defendName, ActionGroup defendGroup, int baseDefense, int enduranceCost, string defendDescription)
	{
		this.defendName = defendName;
		this.defendGroup = defendGroup;
		this.baseDefense = baseDefense;
		this.enduranceCost = enduranceCost;
		this.defendDescription = defendDescription;
	}
}
