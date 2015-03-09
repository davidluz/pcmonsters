using UnityEngine;
using System.Collections;

public class MudarCena : MonoBehaviour {

	public  void goToScene(int cena){
		if (cena == 1) {
						Application.LoadLevel ("Menu");
				}
		if (cena == 2) {
						Application.LoadLevel ("Battle");
				}
		if (cena == 3) {
			Application.LoadLevel ("Training");
		}


	}



	 
	// Use this for initialization
	void Start () {

	


	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
