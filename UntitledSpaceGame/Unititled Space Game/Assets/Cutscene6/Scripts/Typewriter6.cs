﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewriter6 : MonoBehaviour
{
    Text txt;
	string story;

	void Awake () 
	{
		txt = GetComponent<Text>();
		story = txt.text;
		txt.text = "";

		StartCoroutine ("PlayText");
	}

	IEnumerator PlayText()
	{
		foreach (char c in story) 
		{
			txt.text += c;
			yield return new WaitForSeconds (0.03f);
		}
	}
}
