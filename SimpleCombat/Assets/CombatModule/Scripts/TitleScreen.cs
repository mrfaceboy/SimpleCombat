using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	
	enum GameStates{
		TITLE,
		PLAYERSELECT
	}
	
	//window rectangles
	Rect titleWindow = new Rect(0,0,Screen.width,Screen.height);
	Rect playerSelectWindow = new Rect(100, 50,400, 400);
	Rect playerStatsWindow = new Rect(Screen.width - 500, 50, 400, 400);
	
	//button rectangles
	Rect startButton = new Rect(100,Screen.height - 200 ,100,50);
	Rect quitOrBack = new Rect(Screen.width - 200, Screen.height - 200 ,100,50);
	Rect gameStart = new Rect(Screen.width/2 -50,  Screen.height - 200 ,100,50);
	
	
	//menu states
	int currentState = 0;
	
	//selected player
	int selectedPlayer = 0;
	
	
	//determines what window is in focus
	int windowFucus = 0;
	
	//holds all the player crads to choose from as a reference
	public PlayerCard[] cards = new PlayerCard[16];
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// draws the GUI
	void OnGUI(){
		titleWindow = GUI.Window(0,titleWindow, MainWindow,"Simple Combat");
		if (currentState == (int)GameStates.PLAYERSELECT){
			playerSelectWindow = GUI.Window(1,playerSelectWindow, PlayerSelectWindow, "Player Select");
			playerStatsWindow = GUI.Window(2,playerStatsWindow, PlayerStatsWindow, "Player Stats");
		}
	}
	
	
	//draws everything for the main window
	void MainWindow(int windowID){
		
		GUI.BringWindowToBack(0);
		
		if(currentState == (int)GameStates.TITLE){
			
			if(GUI.Button(startButton,"Start")){
				currentState = (int)GameStates.PLAYERSELECT;
			}
			if(GUI.Button(quitOrBack,"Quit")){
				Application.Quit();
			}
		}
		
		if(currentState == (int)GameStates.PLAYERSELECT){
			if(GUI.Button(quitOrBack,"back")){
				currentState = (int)GameStates.TITLE;
			}
			if(selectedPlayer > 0){
				if(GUI.Button(gameStart,"Begin Battle")){
					
					
					
					
					//pass the selected player information to the next
					GameController.getPlayer(cards[selectedPlayer-1]);
					//load the next screen
					Application.LoadLevel("BattleScene");
				}
			}
			
		}
		
		//checks for focus on this window
		if((Event.current.button == 0) && (Event.current.type == EventType.MouseDown)) windowFucus = windowID;
	}
	
	//draws everything for the player select window
	void PlayerSelectWindow(int windowID){
		
		//column 1
		if(GUI.Button(new Rect(20 , 40 , 150,30),cards[0 ].name)) selectedPlayer = 1;
		if(GUI.Button(new Rect(20 , 80 , 150,30),cards[1 ].name)) selectedPlayer = 2;
		if(GUI.Button(new Rect(20 , 120, 150,30),cards[2 ].name)) selectedPlayer = 3;
		if(GUI.Button(new Rect(20 , 160, 150,30),cards[3 ].name)) selectedPlayer = 4;
		if(GUI.Button(new Rect(20 , 200, 150,30),cards[4 ].name)) selectedPlayer = 5;
		if(GUI.Button(new Rect(20 , 240, 150,30),cards[5 ].name)) selectedPlayer = 6;
		if(GUI.Button(new Rect(20 , 280, 150,30),cards[6 ].name)) selectedPlayer = 7;
		if(GUI.Button(new Rect(20 , 320, 150,30),cards[7 ].name)) selectedPlayer = 8;
		
		//column 2
		if(GUI.Button(new Rect(230, 40 , 150,30),cards[8 ].name)) selectedPlayer = 9 ;
		if(GUI.Button(new Rect(230, 80 , 150,30),cards[9 ].name)) selectedPlayer = 10;
		if(GUI.Button(new Rect(230, 120, 150,30),cards[10].name)) selectedPlayer = 11;
		if(GUI.Button(new Rect(230, 160, 150,30),cards[11].name)) selectedPlayer = 12;
		if(GUI.Button(new Rect(230, 200, 150,30),cards[12].name)) selectedPlayer = 13;
		if(GUI.Button(new Rect(230, 240, 150,30),cards[13].name)) selectedPlayer = 14;
		if(GUI.Button(new Rect(230, 280, 150,30),cards[14].name)) selectedPlayer = 15;
		if(GUI.Button(new Rect(230, 320, 150,30),cards[15].name)) selectedPlayer = 16;
		
		//checks for focus on this window
		if((Event.current.button == 0) && (Event.current.type == EventType.MouseDown)) windowFucus = windowID;
		
		//clear selection
		if(Input.GetMouseButtonDown(0) && windowFucus == windowID) selectedPlayer = 0;
		
	}
	
	//draws the stats in the stats window
	void PlayerStatsWindow(int windowID){
		
		GUI.TextArea(new Rect(20, 25, 150, 25), "Attack 1");
		GUI.TextArea(new Rect(20, 55 , 150, 25), "Attack 2");
		GUI.TextArea(new Rect(20, 85 , 150, 25), "Attack 3");
		GUI.TextArea(new Rect(20, 115, 150, 25), "Defence 1");
		GUI.TextArea(new Rect(20, 145, 150, 25), "Defence 2");
		GUI.TextArea(new Rect(20, 175, 150, 25), "Defense 3");
		GUI.TextArea(new Rect(20, 205, 150, 25), "Meditate 1");
		GUI.TextArea(new Rect(20, 235, 150, 25), "Meditate 2");
		GUI.TextArea(new Rect(20, 265, 150, 25), "Meditate 3");
		GUI.TextArea(new Rect(20, 295, 150, 25), "Health");
		GUI.TextArea(new Rect(20, 325, 150, 25), "Stamina");
		GUI.TextArea(new Rect(20, 355, 150, 25), "Stamina Regen Rate");
		
		if(selectedPlayer > 0){
			GUI.TextArea(new Rect(230, 25 , 150, 25), cards[selectedPlayer-1].attack_1.ToString());
			GUI.TextArea(new Rect(230, 55 , 150, 25), cards[selectedPlayer-1].attack_2.ToString());
			GUI.TextArea(new Rect(230, 85 , 150, 25), cards[selectedPlayer-1].attack_3.ToString());
			GUI.TextArea(new Rect(230, 115, 150, 25), cards[selectedPlayer-1].defend_1.ToString());
			GUI.TextArea(new Rect(230, 145, 150, 25), cards[selectedPlayer-1].defend_2.ToString());
			GUI.TextArea(new Rect(230, 175, 150, 25), cards[selectedPlayer-1].defend_3.ToString());
			GUI.TextArea(new Rect(230, 205, 150, 25), cards[selectedPlayer-1].meditate_1.ToString());
			GUI.TextArea(new Rect(230, 235, 150, 25), cards[selectedPlayer-1].meditate_2.ToString());
			GUI.TextArea(new Rect(230, 265, 150, 25), cards[selectedPlayer-1].meditate_3.ToString());
			GUI.TextArea(new Rect(230, 295, 150, 25), cards[selectedPlayer-1].health.ToString());
			GUI.TextArea(new Rect(230, 325, 150, 25), cards[selectedPlayer-1].maxStamina.ToString());
			GUI.TextArea(new Rect(230, 355, 150, 25), cards[selectedPlayer-1].stamRegen.ToString());
		}
		
		
		//checks for focus on this window
		if((Event.current.button == 0) && (Event.current.type == EventType.MouseDown)) windowFucus = windowID;
	}
}
