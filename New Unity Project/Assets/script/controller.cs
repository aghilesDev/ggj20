using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
 
	const string coreString="Core"; 
    // Use this for initialization
    public float moveSpeed=2f;
	private bool played=false;
	private CharacterController planetController;
	private Vector3 moveDirection = Vector3.zero;
	Rigidbody rb;
	void Start () {
		planetController=GetComponent<CharacterController>();
		rb=GetComponent<Rigidbody>();
		
		GameObject.Find(coreString).GetComponent<core>().addPlanet(this.gameObject);
		
	}

	public void setPlayed(bool val)
	{
		played= val;
		rb.useGravity=!val;
	}
	
	 




	// Update is called once per frame
	void Update () {

		if(played){
			rb.velocity=(Vector3.zero);
		}
		
 		if (played==true){

			moveDirection = Vector3.zero;

			if (Input.GetKey(KeyCode.LeftArrow))
			{
				moveDirection.x+=-moveSpeed;			
			}


			if (Input.GetKey(KeyCode.RightArrow))
			{
				moveDirection.x+=moveSpeed;			
			}


			if (Input.GetKey(KeyCode.UpArrow))
			{
				moveDirection.y+=moveSpeed;			
			}

			if (Input.GetKey(KeyCode.DownArrow))
			{
				moveDirection.y+=-moveSpeed;			
			}
			transform.Translate(moveDirection * Time.deltaTime);



		 }
		
	}
}
