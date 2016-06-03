﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.NumberWizard
{
public class NumberWizard : MonoBehaviour {

	List<int> guesses = new List<int>();
	int max;
	int initialmax;
	int min;
	int initialmin;
	double guess;
	int count;
	int diff;
	double initialguess;
	KeyCode code;

//used float because there isnt a Math in Unity, only a Mathf
	void Start () {
		
		StartGame();
	}
	
	void Update () {
		
		
		handleInput ();
		if (Input.GetKeyDown("up")) {
			if (guess == initialmax-1){
				print (guess);
				guess++;
				print (guess);
				RightAnswer();
				return;
			}
			min = (int) guess;
			NextGuess();
		}
		else if (diff <= 1 ) {
			print ("Your number is " + guess + "\n");
			print (guess+ "g"+max+"max"+min+"min");
			Winning();
		}
		else if (Input.GetKeyDown("down")) {
			if (guess == (initialmin+1)){
				guess--;
				RightAnswer();
				return;
			}
			max = (int) guess;
			NextGuess();
		}
		else if (Input.GetKeyDown("return")||Input.GetKeyDown("enter")) {
			Winning ();
			
		}
	}

	void handleInput ()
	{
		throw new System.NotImplementedException ();
	}
	
	void StartGame () {
		
		max = 1000;
		initialmax = max;
		min = 1;
		initialmin = min;
		guess = System.Math.Round (((double)max + (double)min) / 2);
		diff = System.Math.Abs (max-min);
		count = 1;
		initialguess = guess;
		print ("================================================\n");
		print ("Welcome to Number Wizard\n");
		print ("Pick a number in your head and punch a baby seal.\n");
		
		print ("Max value is " + max +"\n");
		print ("Min value is " + min + "\n");
		
		Instructions();

		//max = max + 1;
		//min = min - 1;
	}
	void RightAnswer() {
		print ("Your number is " + guess + "\n");
		//print (guess+ "g"+max+"max"+min+"min");
		Winning();
	}
	void Instructions () {
		print("Is the # higher or lower than " + guess + "\n");
		print ("[UP] for higher; [DOWN] for lower; [RETURN] for equal\n");
	}
	void NextGuess () {
		
		count ++;
		guess = System.Math.Round (((double)max + (double)min) / 2);
		diff = Mathf.Abs (max-min);
		//print (guess+ "g"+max+"max"+min+"min"+diff+"\n");
		Instructions();

	}
	
	void Liar () {
		print ("You are a liar.  You should move to Portland.");
		StartGame();
	}
	
	void Winning () {
		print ("I won in " + count +" guesses. Have a safe flight.\n");
		StartGame();
	}
	// Update is called once per frame
	//liars 50 = guess - but pick up or down on the first guess 
	//
	
}
}