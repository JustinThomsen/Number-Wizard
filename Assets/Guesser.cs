//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.NumberWizard
{
	public class Guesser
	{
		public int currentMin;
		public int currentMax;
		public int currentGuess;
		public int guess;
		public int count;
		public int Guess (int min, int max, KeyCode code)
		{
			currentMin = min;
			currentMax = max;
			currentGuess = (min + max)/2;
			if (code == KeyCode.UpArrow) {
				currentMin = currentGuess;
				guess = (int)(currentMax + currentGuess) / 2;
				count++;

				return guess;
			} else
			if (code == KeyCode.DownArrow) {
				currentMax = currentGuess;
				guess = (int)(currentMin + currentGuess) / 2;
				return guess;
			} else
			return currentGuess;
		}

	}

}
