using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelectionController : MonoBehaviour {

	// Use this for initialization
	const string coreString="Core"; 
	private List<GameObject> planets;
	private GameObject currentPlanet;
	private int currentPlanetIndexe;
	private bool finish;
	private bool planetSwitched;
	void Start () {
		finish=false;
		planets=GameObject.Find(coreString).GetComponent<core>().getPlanets();
		planetSwitched=false;
		Debug.Log("planets"+ planets.Count);
		if(planets.Count!=0){
			currentPlanet=planets[0];
			currentPlanetIndexe=0;
		}else{
			finish=true;
		}
	}
	public GameObject getCurrentPlanet(){
		return currentPlanet;
	}
	// Update is called once per frame
	void Update () {
		planets=GameObject.Find(coreString).GetComponent<core>().getPlanets();
	
		planetSwitched=false;
		//left right sur x

		if(Input.GetKey(KeyCode.LeftArrow)){
			Debug.Log("nb planet"+ planets.Count);
			currentPlanetIndexe = ((currentPlanetIndexe-1)%planets.Count);
			if(currentPlanetIndexe<0){
				currentPlanetIndexe=planets.Count+currentPlanetIndexe;
			}
			Debug.Log("nouvelle indexe"+ currentPlanetIndexe);
			planetSwitched=true;

		}

		if(Input.GetKey(KeyCode.RightArrow)){
			currentPlanetIndexe=(currentPlanetIndexe+1)%planets.Count;	
			planetSwitched=true;		
		}

		if(planetSwitched){
			this.unselectPlanet(currentPlanet);
			currentPlanet=planets[currentPlanetIndexe];
			this.selectPlanet(currentPlanet);
		}
	}

	private void selectPlanet(GameObject Planet){

	}

		private void unselectPlanet(GameObject Planet){
		
	}
}
