using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class SceneManager : MonoBehaviour {

	public Text mensagem;
	public void createMonster(){

	}

	public void mudaTexto(){
		mensagem.text = "A batalhar terminou";
	}


	public void changeScene(int sceneNumber){

		if (sceneNumber == 1) {
			Application.LoadLevel ("Scene1");
				}
		if (sceneNumber == 2) {
			Application.LoadLevel ("Scene2");
		}
		if (sceneNumber == 3) {
			Application.LoadLevel ("Scene3");
		}

		if (sceneNumber == 4) {
			Application.LoadLevel ("Scene4");
		}

		}

}
