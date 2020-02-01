using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class core : MonoBehaviour {

	public  const int _PLAYMODE_PLAYER_SELECT=0;
	public  const int _PLAYMODE_PLANET_SELECT=1;
	public  const int _PLAYMODE_PLANET_MANIPULATION=2;
	

	public int currentMode;
	private GameObject player;
	private bool modeSwitched;
	private bool isPlanetSelectionMode;

	private List<GameObject> planets;
	private GameObject currentPlanet;

	private float tempsDebut=-2f;
	private const  float Quantum=0.5f;


	// Use this for initialization
	void Start () {
		planets= new List<GameObject>();
		currentMode=_PLAYMODE_PLAYER_SELECT;
		activePlayerManipulationMode();
	}
	
	public List<GameObject> getPlanets(){
		return planets;
	}
	public void addPlanet(GameObject planet)
	{
		planets.Add(planet);

	}

	public void disableControllers()
	{
		foreach (GameObject planet in planets)
		{
			planet.GetComponent<controller>().setPlayed(false);
		}
	}


	public void switchModeUp(){
		
		switch(this.currentMode){
			case _PLAYMODE_PLANET_MANIPULATION:
				stopPlanetManipulationMode();
				break;
			case _PLAYMODE_PLANET_SELECT:
				stopPlanetSelectionMode();
				break;
			case _PLAYMODE_PLAYER_SELECT:
				stopPlayerManipulationMode();
				break;
			default:
				Debug.Log("ERREUR valeur current mode invalide");
				break;

		}

		currentMode=(currentMode+1)%3;
		
		Debug.Log( currentMode);
	}

	public void switchModeDown(){
		
		switch(this.currentMode){
			case _PLAYMODE_PLANET_MANIPULATION:
				stopPlanetManipulationMode();
				break;
			case _PLAYMODE_PLANET_SELECT:
				stopPlanetSelectionMode();
				break;
			case _PLAYMODE_PLAYER_SELECT:
				stopPlayerManipulationMode();
				break;
			default:
				Debug.Log("ERREUR valeur current mode invalide");
				break;

		}

		currentMode=(currentMode-1)%3;
		if(currentMode<0){
			currentMode=3+currentMode;
		}
		
		Debug.Log( currentMode);
	}
	
	// Update is called once per frame
	void Update () {
		
		modeSwitched=false;
		
		if(Input.GetKey(KeyCode.Space )&& Time.time-tempsDebut>=Quantum){
			tempsDebut=Time.time;
			Debug.Log("ok");
			this.switchModeUp();
			modeSwitched=true;
		}

		if(modeSwitched){
			switch(this.currentMode){
				case _PLAYMODE_PLANET_MANIPULATION:
					activePlanetManipulationMode();
					break;
				case _PLAYMODE_PLANET_SELECT:
					activePlanetSelectionMode();
					break;
				case _PLAYMODE_PLAYER_SELECT:
					activePlayerManipulationMode();
					break;
				default:
					Debug.Log("ERREUR valeur current mode invalide");
					break;

			}
		}


		
	}

	public void activePlanetManipulationMode()
	{
		//active script of the curent planet
		currentPlanet.GetComponent<controller>().setPlayed(true);

	}

	public void activePlanetSelectionMode()
	{
		//active script controlle Planet
		this.gameObject.GetComponent<PlanetSelectionController>().enabled=true;
	}

	public void activePlayerManipulationMode()
	{
		//active script of player
		const string  playerString="player";
		GameObject.Find(playerString).GetComponent<playerCustomController>().enabled=true;
	}


	public void stopPlanetManipulationMode()
	{
		//desactive script of the curent planet
		currentPlanet.GetComponent<controller>().setPlayed(false);
		
	}

	public void stopPlanetSelectionMode()
	{
		//desactive script controlle Planet
		currentPlanet=this.gameObject.GetComponent<PlanetSelectionController>().getCurrentPlanet();
		this.gameObject.GetComponent<PlanetSelectionController>().enabled=false;
	}

	public void stopPlayerManipulationMode()
	{
		//desactive script of player
		const string  playerString="player";
		GameObject.Find(playerString).GetComponent<playerCustomController>().enabled=false;
	}



}
