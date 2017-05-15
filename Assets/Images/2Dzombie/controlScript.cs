using UnityEngine;
using System.Collections;

public class controlScript : MonoBehaviour {
	
	Animator anim;
	void Awake () {anim=GetComponent<Animator>();}
	
	void Start () {
		anim.Play("idle1");
	}
	//---------------------------
	void OnGUI() {
		
		 GUIStyle customButton = new GUIStyle("button");
		customButton.fontSize =24;
		
        //if (GUI.Button(new Rect(10, 10, 150, 50), "Enter",customButton))anim.Play("enter");
		
		if (GUI.Button(new Rect(10, 80, 150, 50), "Idle1",customButton))anim.Play("idle1");
		
		//if (GUI.Button(new Rect(10, 150, 150, 50), "Idle2",customButton))anim.Play("idle2");
		
		if (GUI.Button(new Rect(10, 220, 150, 50), "WalkSide",customButton))anim.Play("walkSide");
		
		if (GUI.Button(new Rect(10, 290, 150, 50), "WalkUp",customButton))anim.Play("walkUp");
		
		if (GUI.Button(new Rect(Screen.width-160, 10, 150, 50), "WalkDown",customButton))anim.Play("walkDown");
		
		if (GUI.Button(new Rect(Screen.width-160, 80, 150, 50), "Strike",customButton))anim.Play("strike");
		
		//if (GUI.Button(new Rect(Screen.width-160, 150, 150, 50), "Bite",customButton))anim.Play("bite");
		
		if (GUI.Button(new Rect(Screen.width-160, 220, 150, 50), "Die",customButton))anim.Play("die");
		
		if (GUI.Button(new Rect(Screen.width-160, 290, 150, 50), "Headshot",customButton))anim.Play("headshot");
		
		
		//if (GUI.Button(new Rect(10, 360, 150, 50), "StrikeSide",customButton))anim.Play("strikeSide");
		
		//if (GUI.Button(new Rect(10, 430, 150, 50), "StrikeUp",customButton))anim.Play("strikeUp");
		
		//if (GUI.Button(new Rect(10, 500, 150, 50), "StrikeDown",customButton))anim.Play("strikeDown");
		
		
		if (GUI.Button(new Rect(Screen.width-160, 360, 150, 50), "JumpSide",customButton))anim.Play("jumpSide");
		
		if (GUI.Button(new Rect(Screen.width-160, 430, 150, 50), "JumpUp",customButton))anim.Play("jumpUp");
		
		if (GUI.Button(new Rect(Screen.width-160, 500, 150, 50), "JumpDown",customButton))anim.Play("jumpDown");
		
		
    }// end of ongui
}
