using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {
		start, continue_0, continue_1, cell, sheets_0, lock_0, plate_0, fork_0, cell_hairclip, lock_1, fork_1, plate_1,
		inventory_0, hairclip_0, hairclip_1, cell_hairclip_fork_0, cell_hairclip_fork_1,  plate_3, inventory_3, lock_3,
		cell_fork, inventory_1, fork_2, bent_fork_0, sheets_2, plate_4, lock_4, plate_2, sheets_1, lock_2, inventory_2,
		hairclip_2, hairclip_3, fork_3, cell_hairclip_bent_fork, bent_fork_1, bent_fork_2, bent_fork_3, take_sheets,
		plate_5, lock_5, freedom, plate_6, outro, play_again, exit, inventory_4, plate_7, lock_6, hairclip_4, hairclip_5,
		fork_4, bent_fork_4
		};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.start;	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.start)					{start();}
		else if (myState == States.continue_0)				{continue_0();}
		else if (myState == States.continue_1)				{continue_1();}
		else if (myState == States.cell)					{cell();}
		else if (myState == States.sheets_0)				{sheets_0();}
		else if (myState == States.lock_0)					{lock_0();}
		else if (myState == States.plate_0)					{plate_0();}
		else if (myState == States.fork_0)					{fork_0();}
		else if (myState == States.cell_hairclip)			{cell_hairclip();}
		else if (myState == States.lock_1)					{lock_1();}
		else if (myState == States.fork_1)					{fork_1();}
		else if (myState == States.plate_1)					{plate_1();}
		else if (myState == States.inventory_0)				{inventory_0();}
		else if (myState == States.hairclip_0)				{hairclip_0();}
		else if (myState == States.cell_hairclip_fork_0)	{cell_hairclip_fork_0();}
		else if (myState == States.cell_hairclip_fork_1)	{cell_hairclip_fork_1();}
		else if (myState == States.plate_3)					{plate_3();}
		else if (myState == States.inventory_3)				{inventory_3();}
		else if (myState == States.lock_3)					{lock_3();}
		else if (myState == States.cell_fork)				{cell_fork();}
		else if (myState == States.inventory_1)				{inventory_1();}
		else if (myState == States.fork_2)					{fork_2();}
		else if (myState == States.bent_fork_0)				{bent_fork_0();}
		else if (myState == States.sheets_2)				{sheets_2();}
		else if (myState == States.plate_4)					{plate_4();}
		else if (myState == States.lock_4)					{lock_4();}
		else if (myState == States.plate_2)					{plate_2();}
		else if (myState == States.sheets_1)				{sheets_1();}
		else if (myState == States.lock_2)					{lock_2();}
		else if (myState == States.inventory_2)				{inventory_2();}
		else if (myState == States.hairclip_2)				{hairclip_2();}
		else if (myState == States.hairclip_3)				{hairclip_3();}
		else if (myState == States.fork_3)					{fork_3();}
		else if (myState == States.cell_hairclip_bent_fork)	{cell_hairclip_bent_fork();}
		else if (myState == States.bent_fork_1)				{bent_fork_1();}
		else if (myState == States.bent_fork_2)				{bent_fork_2();}
		else if (myState == States.bent_fork_3)				{bent_fork_3();}
		else if (myState == States.take_sheets)				{take_sheets();}
		else if (myState == States.plate_5)					{plate_5();}
		else if (myState == States.lock_5)					{lock_5();}
		else if (myState == States.freedom)					{freedom();}
		else if (myState == States.plate_6)					{plate_6();}
		else if (myState == States.outro)					{outro();}
		else if (myState == States.exit)					{exit();}
		else if (myState == States.inventory_4)				{inventory_4();}
		else if (myState == States.plate_7)					{plate_7();}
		else if (myState == States.lock_6)					{lock_6();}
		else if (myState == States.hairclip_4)				{hairclip_4();}
		else if (myState == States.hairclip_5)				{hairclip_5();}
		else if (myState == States.fork_4)					{fork_4();}
		else if (myState == States.bent_fork_4)				{bent_fork_4();}
	}
	
	#region Intro
	void start () {
		text.text = "Hello and Welcome to my first Escape Game\n\n" +
					"Press Enter to Start" ;
		if (Input.GetKeyDown(KeyCode.Return)) 	{myState = States.continue_0;}
	}
	void continue_0 () {
		text.text = "The DM desided to start you in a prison cell.\n " +
					"You cannot remember anything and you have no idea " +
					"why you are in this cell. The only thing you know " +
					"is that you must get out no matter what.\n " +
					"( DM's choise ).\n\n " +
					"Press Space to Continue" ;
		if (Input.GetKeyDown(KeyCode.Space)) 	{myState = States.continue_1;}
	}
	
	void continue_1 () {
		text.text = "In the cell there is a bed, some dirty sheets on the bed, " +
					"an empty wooden plate on the floor and a dirty fork next " +
					"to the plate.\n\n" +
					"Press Space to Continue" ;
		if (Input.GetKeyDown(KeyCode.Space)) 	{myState = States.cell;}
	}
	#endregion
	
	#region Scene 1
	void cell () {
		text.text = "The cell's door is locked!\n\n " +
					"Press S to view the Sheets, P to view the Plate, F to view the Fork and L to view the Lock" ;
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_0;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.fork_0;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_0;}
	}
	
	void sheets_0 () {
		text.text = "I can't believe I was sleeping in these sheets. " +
					"The pleasure of prison life....\n " +
					"I guess!\n\n " +
					"Press T to Take the sheets or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_hairclip;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
	}
	
	void plate_0 () {
		text.text = "It's an empty and dirty wooden plate.\n " +
					"Probably I ate something disgusting but I can't remember.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void fork_0 () {
		text.text = "A dirty and used fork\n\n " +
					"Press T to Take the fork or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_fork;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
	}
	
	void lock_0 () {
		text.text = "You look outside the cell. The corridor is empty and " +
					"quiet. The lock is rusry and simple. You could easy " +
					"open it if you had the appropriate tools.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;} 
	}
	#endregion
	
	#region Scene 2
	void cell_hairclip () {
		text.text = "When you move the sheets from the bed you notice that something " +
					"drops on the floor. It's a hair clip.\n " +
					"Where was that? It doesn't matter, it might be handy\n " +
					"(A Hair Clip added to yout Inventory)\n\n " +
					"Press I to open your Inventory, P to view the Plate, F to view the Fork and L to view the Lock" ;
		if (Input.GetKeyDown(KeyCode.I)) 		{myState = States.inventory_0;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_1;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.fork_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_1;}
	}
	
	void inventory_0 () {
		text.text = "Press H to Select the Hair Clip or R to Return" ;
		if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.hairclip_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_hairclip;}
	}
	
	void plate_1 () {
		text.text = "Still the same empty and dirty plate.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip;} 
	}
	
	void fork_1 () {
		text.text = "A dirty and used fork.\n\n " +
					"Press T to Take the fork or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_hairclip_fork_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_hairclip;}
	}
	
	void lock_1 () {
		text.text = "The lock is simple but i can't use the hair clip alone.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip;} 
	}
	
		#region Scene 2.1
		void hairclip_0 () {
			text.text = "Press U to Use the Hair Clip or R to Return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.hairclip_1;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_0;}
		}
	
		void hairclip_1 () {
			text.text = "I don't know how to use it on myself!\n\n " +
						"Press R to Return" ;
			if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.hairclip_0;} 
		}
		#endregion
	#endregion
	
	#region Scene 3
	void cell_fork () {
		text.text = "Under normal circumstances I wouldn't put a dirty fork " +
					"in my pocket but now it might be usefull in the near future.\n " +
					"(A Fork added to your Inventory)\n\n " +
					"Press I to Open your Inventory, P to view the Plate, S to view the Sheets and L to View the Lock" ;
		if (Input.GetKeyDown(KeyCode.I)) 		{myState = States.inventory_1;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_2;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_2;}
	}
	
	void inventory_1 () {
		text.text = "Press F to Select the Fork or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.F)) 		{myState = States.fork_2;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_fork;}
	}
	
	void plate_2 () {
		text.text = "There is nothing to eat at the moment. After all I am not hungry.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_fork;}
	}
	
	void sheets_1 () {
		text.text = "I can't believe I was sleeping in these sheets. " +
					"The pleasure of prison life....\n " +
					"I guess!\n\n " +
					"Press T to Take the sheets or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_hairclip_fork_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_fork;}
	}
	
	void lock_2 () {
		text.text = "Still something's missing.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_fork;}
	}
		
		#region Scene 3.1
		void fork_2 () {
			text.text = "Press U to Use the Fork or R to Return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.bent_fork_0;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_1;}
		}
		#endregion
	#endregion
	
	#region Scene 4a
	void cell_hairclip_fork_0 () {
		text.text = "Under normal circumstances I wouldn't put a dirty fork " +
					"in my pocket but now it might be usefull in the near future.\n " +
					"(A Fork added to your Inventory)\n\n " +
					"Press I to Open your Inventory, P to view the Plate and L to View the Lock" ;
		if (Input.GetKeyDown(KeyCode.I)) 		{myState = States.inventory_3;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_3;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_3;}
	}
	
	void inventory_3 () {
		text.text = "Press H to Select the Hair Clip, F to Select the Fork or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.hairclip_2;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.fork_3;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_hairclip_fork_0;}
	}
	
	void plate_3 () {
		text.text = "There is nothing to eat at the moment. After all I am not hungry.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip_fork_0;}
	}
	
	void lock_3 () {
		text.text = "I need to do something else first.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip_fork_0;}
	}
	
		#region Scene 4.1a
		void hairclip_2 () {
			text.text = "Press U to Use the Hair Clip or R to Return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.hairclip_3;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_3;}
		}
	
		void hairclip_3 () {
			text.text = "I don't know how to use it on myself!\n\n " +
						"Press R to Return" ;
			if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.hairclip_2;}
		}
	
		void fork_3 () {
			text.text = "Press U to Use the Fork or R to Return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.bent_fork_3;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_3;}
		}
	
		void bent_fork_3 () {
			text.text = "If I bent it like this it might fit.\n " +
						"(A bent Fork added to your Inventory)\n\n " +
						"Press Space to Continue or R to Return" ;
			if (Input.GetKeyDown(KeyCode.Space)) 	{myState = States.cell_hairclip_bent_fork;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.fork_3;}
		}
		#endregion
	#endregion
		
	#region Scene 4b
	void cell_hairclip_fork_1 () {
		text.text = "When you move the sheets from the bed you notice that something " +
					"drops on the floor. It's a hair clip.\n " +
					"Where was that? It doesn't matter, it might be handy\n " +
					"(A Hair Clip added to yout Inventory)\n\n " +
					"Press I to open your Inventory, P to view the Plate and L to view the Lock" ;
		if (Input.GetKeyDown(KeyCode.I)) 		{myState = States.inventory_4;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_7;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_6;}
	}
	
	void inventory_4 () {
		text.text = "Press H to Select the Hair Clip, F to Select the Fork or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.hairclip_4;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.fork_4;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_hairclip_fork_1;}
	}
	
	void plate_7 () {
		text.text = "There is nothing to eat at the moment. After all I am not hungry.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip_fork_1;}
	}
	
	void lock_6 () {
		text.text = "I need to do something else first.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip_fork_1;}
	}
	
		#region Scene 4.1b
		void hairclip_4 () {
			text.text = "Press U to Use the Hair Clip or R to Return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.hairclip_5;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_4;}
		}
	
		void hairclip_5 () {
			text.text = "I don't know how to use it on myself!\n\n " +
						"Press R to Return" ;
			if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.hairclip_4;}
		}
	
		void fork_4 () {
			text.text = "Press U to Use the Fork or R to Return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.bent_fork_4;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_4;}
		}
	
		void bent_fork_4 () {
			text.text = "If I bent it like this it might fit.\n " +
						"(A bent Fork added to your Inventory)\n\n " +
						"Press Space to Continue or R to Return" ;
			if (Input.GetKeyDown(KeyCode.Space)) 	{myState = States.cell_hairclip_bent_fork;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.fork_3;}
		}
		#endregion
	#endregion
	
	#region Scene 5
	void bent_fork_0 () {
		text.text = "If I bent it lick this it might fit.\n " +
					"(A bent Fork added to your Inventory)\n\n " +
					"Press I to Open your Inventory, S to view the Sheets, P to view the Plate and L to View the Lock" ;
		if (Input.GetKeyDown(KeyCode.I)) 		{myState = States.inventory_2;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_4;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.sheets_2;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_4;}
	}
	
	void inventory_2 () {
		text.text = "Press F to Select the Bent Fork or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.F)) 		{myState = States.bent_fork_1;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.bent_fork_0;}
	}
	
	void plate_4 () {
		text.text = "I can't use it anymore, the fork is bent.\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.bent_fork_0;}
	}
	
	void sheets_2 () {
		text.text = "These dirty sheets again. Ugh!\n\n" +
					"Press T to Take the sheets or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.take_sheets;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.bent_fork_0;}
	}
	
	void lock_4 () {
		text.text = "Still missing something\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.bent_fork_0;}
	}
	
		#region Sceene 5.1
		void bent_fork_1 () {
			text.text = "Press U to Use the Bent Fork or R to return" ;
			if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.bent_fork_2;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.inventory_2;}
		}
		void bent_fork_2 () {
			text.text = "It's already bent.\n\n " +
						"Press R to Return" ;
			if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.bent_fork_1;}
		}
		
		void take_sheets () {
		text.text = "When you move the sheets from the bed you notice that something " +
					"drops on the floor. It's a hair clip.\n " +
					"Where was that? It doesn't matter, it might be handy\n " +
					"(A Hair Clip added to yout Inventory)\n\n " +
					"Press Space to Continue or R to Return" ;
			if (Input.GetKeyDown(KeyCode.Space)) 	{myState = States.cell_hairclip_bent_fork;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.sheets_2;}
		}
		#endregion
	#endregion
	
	#region Scene 6
	void cell_hairclip_bent_fork () {
		text.text = "OK. Now what's next?\n\n " +
					"Press P to view the Plate and L to View the Lock" ;
		if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.plate_5;}
		else if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_5;}
	}
	
	void plate_5 () {
		text.text = "Just leave the @*#$ plate in peace and get me out of here\n\n " +
					"Press R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_hairclip_bent_fork;}
	}
	
	void lock_5 () {
		text.text = "The corridor is still empty, now is my my chance!\n\n " +
					"Press U to Unlock the door or R to Return and explore your cell" ;
		if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.freedom;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell_hairclip_bent_fork;}
	}
	#endregion
	
	#region Final Scene
	void freedom () {
		text.text = "FINALY! I'm out\n " +
					"Did I forget something?\n\n " +
					"Press Esc to Escape or P to view the Plate" ;
		if (Input.GetKeyDown(KeyCode.Escape)) 	{myState = States.outro;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.plate_6;}
	}
	
	void plate_6 () {
		text.text = "-Hey! Who's there?\n " +
					"-Oh NOOOOO!!!\n " +
					"-HE'S TRYING TO ESCAPE! LOCK HIM IN AGAIN!\n\n " +
					"Press Space to Continue" ;
		if (Input.GetKeyDown(KeyCode.Space)) 	{myState = States.outro;}
	}
	#endregion
	
	#region Credits
	void outro () {
		text.text = "Thanks for playing my first Escape Atempt :D\n " +
					"Hope you enjoyed!\n\n " +
					"Press Esc to Exit or P to Plate (Play) Again" ;
		if (Input.GetKeyDown(KeyCode.Escape)) 	{myState = States.exit;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.continue_0;}
	}
	
	void exit () {
		text.text = "Just close the Window!\n " +
					"I haven't figured out yet how to make a game close on it's own." ;
	}
	#endregion
}
