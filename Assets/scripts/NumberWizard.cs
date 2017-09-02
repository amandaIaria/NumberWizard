using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		//you could still use input.getkeydown("up")
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.Return)){
			print ("======= I won =======");
			StartGame();
		}
	}
	
	//void is because we are returning nothing
	void StartGame () {
		//resetting the variables
		max = 1000;
		min = 1;
		guess = 500;	
		
		//Prints in the console
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		//overloading (?) I will need to check what that is
		print ("The highest number you can pick is " + max + " and the lowest can be " + min );
		
		//affordiance telling what the player need to do
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equals");
		
		// Challenge answer - We need to reset the variables For the start of the game. Otherwise if will only stay with your guess.
		
		//This will always allow you to guess 1000, otherwise when the rounding happens it will round down to 999
		max = max + 1;
		
	}
	
	void NextGuess() {
		guess = (min + max)/2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equals");
	}
}
