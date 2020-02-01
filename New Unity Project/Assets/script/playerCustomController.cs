using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCustomController : MonoBehaviour {

    public float moveSpeed=2f;
	private CharacterController playController;
	private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
		playController=GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		 moveDirection = Vector3.zero;

			if (Input.GetKey(KeyCode.LeftArrow))
			{
				moveDirection.x-=moveSpeed;			
			}


			if (Input.GetKey(KeyCode.RightArrow))
			{
				moveDirection.x+=moveSpeed;			
			}

			playController.Move(moveDirection * Time.deltaTime);
		
	}
}
