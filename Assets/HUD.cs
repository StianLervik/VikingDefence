using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD : MonoBehaviour {

	public GameObject menu;
	public GameObject menuP2;
	public GameObject instructions;
	public GameObject options;
	public Slider music;
	public Slider sfx;
	public bool openMenu;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
		instructions.SetActive (false);
		options.SetActive (false);
		music.value = 1;
		sfx.value = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			if (menu.activeSelf == false) {
				menuP2.SetActive (true);
				menu.SetActive (true);
			} else {
				menuP2.SetActive (false);
				menu.SetActive (false);
				instructions.SetActive (false);
				options.SetActive (false);
			}
		}
		if (menu.activeSelf == true) {
			openMenu = true;
		} else {
			openMenu = false;
		}
	}
	public void Instructions(){
		menuP2.SetActive (false);
		instructions.SetActive (true);
	}
	public void InstructionsReturn(){
		menuP2.SetActive (true);
		instructions.SetActive (false);
	}
	public void BackToGame(){
		menuP2.SetActive (false);
		menu.SetActive (false);
	}
	public void OpToMen(){
		menuP2.SetActive (true);
		options.SetActive (false);
	}
	public void Options(){
		menuP2.SetActive (false);
		options.SetActive (true);
	}
	public void Quit(){
		Application.Quit ();
	}
}
