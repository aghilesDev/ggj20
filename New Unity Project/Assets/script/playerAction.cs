using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAction : MonoBehaviour {

	// Use this for initialization
	
	private List<KeyCode> firstJoystickLeft;
	private List<KeyCode> firstJoystickRight;
	private List<KeyCode> firstJoystickUp;
	private List<KeyCode> firstJoystickDown;

	private List<KeyCode> secondJoystickLeft;
	private List<KeyCode> secondJoystickRight;
	private List<KeyCode> secondJoystickUp;
	private List<KeyCode> secondJoystickDown;

	private List<KeyCode> button1;//X
	private List<KeyCode> button2;//O
	private List<KeyCode> button3;//Delt
	private List<KeyCode> button4;//Square
	private List<KeyCode> button5;//R1
	private List<KeyCode> button6;//R2
	private List<KeyCode> button7;//R3
	private List<KeyCode> button8;//R4
	private List<KeyCode> pause;//start
	private List<KeyCode> select;//select
	private List<KeyCode> PAD;//PAD

	public void addFirstJoystickLeft(KeyCode val){
		firstJoystickLeft.Add(val);
	}
	public void addFirstJoystickRight(KeyCode val){
		firstJoystickRight.Add(val);
	}
	public void addFirstJoystickUp(KeyCode val){
		firstJoystickUp.Add(val);
	}
	public void addFirstJoystickDown(KeyCode val){
		firstJoystickDown.Add(val);
	}
	public void addSecondJoystickLeft(KeyCode val){
		secondJoystickLeft.Add(val);
	}
	public void addSecondJoystickRight(KeyCode val){
		secondJoystickRight.Add(val);
	}
	public void addSecondJoystickUp(KeyCode val){
		secondJoystickUp.Add(val);
	}
	public void addSecondJoystickDown(KeyCode val){
		secondJoystickDown.Add(val);
	}
	public void addButton1(KeyCode val){
		button1.Add(val);
	}
	public void addButton2(KeyCode val){
		button2.Add(val);
	}
	public void addButton3(KeyCode val){
		button3.Add(val);
	}
	public void addButton4(KeyCode val){
		button4.Add(val);
	}
	public void addButton5(KeyCode val){
		button5.Add(val);
	}
	public void addButton6(KeyCode val){
		button6.Add(val);
	}
	public void addButton7(KeyCode val){
		button7.Add(val);
	}
	public void addButton8(KeyCode val){
		button8.Add(val);
	}
	public void addPause(KeyCode val){
		pause.Add(val);
	}
	public void addSelect(KeyCode val){
		select.Add(val);
	}
	public void addPAD(KeyCode val){
		PAD.Add(val);
	}

//isPresed

/* 	public void FirstJoystickLeftIsPressed(KeyCode val){
		foreach (KeyCode item in firstJoystickLeft)
		{
			if()
		}
	}
	public void FirstJoystickRightIsPressed(KeyCode val){
		foreach (KeyCode item in firstJoystickRight)
		{
			if()
		}
	}
	public void FirstJoystickUpIsPressed(KeyCode val){
		foreach (KeyCode item in firstJoystickUp)
		{
			if()
		}
	}
	public void FirstJoystickDownIsPressed(KeyCode val){
		foreach (KeyCode item in firstJoystickDown)
		{
			if()
		}
	}
	public void SecondJoystickLeftIsPressed(KeyCode val){
		foreach (KeyCode item in secondJoystickLeft)
		{
			if()
		}
	}
	public void SecondJoystickRightIsPressed(KeyCode val){
		foreach (KeyCode item in secondJoystickRight)
		{
			if()
		}
	}
	public void SecondJoystickUpIsPressed(KeyCode val){
		foreach (KeyCode item in secondJoystickUp)
		{
			if()
		}
	}
	public void SecondJoystickDownIsPressed(KeyCode val){
		foreach (KeyCode item in secondJoystickDown)
		{
			if()
		}
	}
	public void Button1IsPressed(KeyCode val){
KeyCode	foreach (var item in button1)
		{
		if()	
		}
	}
	public void Button2IsPressed(KeyCode val){
KeyCode	foreach (var item in button2)
		{
		if()	
		}
	}
	public void Button3IsPressed(KeyCode val){
KeyCode	foreach (var item in button3)
		{
		if()	
		}
	}
	public void Button4IsPressed(KeyCode val){
KeyCode	foreach (var item in button4)
		{
		if()	
		}
	}
	public void Button5IsPressed(KeyCode val){
KeyCode	foreach (var item in button5)
		{
		if()	
		}
	}
	public void Button6IsPressed(KeyCode val){
KeyCode	foreach (var item in button6)
		{
		if()	
		}
	}
	public void Button7IsPressed(KeyCode val){
KeyCode	foreach (var item in button7)
		{
		if()	
		}
	}
	public void Button8IsPressed(KeyCode val){
KeyCode	foreach (var item in button8)
		{
		if()	
		}
	}
	public void PauseIsPressed(KeyCode val){
KeyCode	foreach (var item in pause)
		{
		if()	
		}
	}
	public void SelectIsPressed(KeyCode val){
KeyCode	foreach (var item in select)
		{
		if()	
		}
	}
	public void PADIsPressed(KeyCode val){
KeyCode	foreach (var item in PAD)
		{
		if()	
		}
	}
*/





	void Start () {
		firstJoystickLeft = new List<KeyCode>();
		firstJoystickRight = new List<KeyCode>();
		firstJoystickUp = new List<KeyCode>();
		firstJoystickDown = new List<KeyCode>();
		secondJoystickLeft = new List<KeyCode>();
		secondJoystickRight = new List<KeyCode>();
		secondJoystickUp = new List<KeyCode>();
		secondJoystickDown = new List<KeyCode>();
		button1 = new List<KeyCode>();
		button2 = new List<KeyCode>();
		button3 = new List<KeyCode>();
		button4 = new List<KeyCode>();
		button5 = new List<KeyCode>();
		button6 = new List<KeyCode>();
		button7 = new List<KeyCode>();
		button8 = new List<KeyCode>();
		pause = new List<KeyCode>();
		select = new List<KeyCode>();
		PAD = new List<KeyCode>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
