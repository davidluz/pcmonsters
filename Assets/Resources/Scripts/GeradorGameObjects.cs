using UnityEngine;
using System.Collections;

public class GeradorGameObjects : MonoBehaviour {

	//public GameObject personagem = null;

	public GameObject objeto1;
	private float nextActionTime = 0.0f; 
	public float period = 2.9f;

	// Use this for initialization
	void Start () {
				
	
		}


	void Update () {


		if (Time.time > nextActionTime ) {
			nextActionTime += period; 
			objeto1 = Instantiate(objeto1,new Vector3((int)Random.Range(-10, 10),10,10), Quaternion.identity)as GameObject;	
		}

	
	
	}
}





