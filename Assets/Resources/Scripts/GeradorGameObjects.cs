using UnityEngine;
using System.Collections;

public class GeradorGameObjects : MonoBehaviour {

	public GameObject personagem = null;

	public GameObject objeto1;
	private float nextActionTime = 0.0f; 
	public float period = 0.1f;

	// Use this for initialization
	void Start () {
				
	
		}


	void Update () {


		if (Time.time > nextActionTime ) {
			nextActionTime += period; 
			objeto1 = Instantiate(Resources.Load("pre2"),new Vector3((int)Random.Range(-10, 10),10,10), Quaternion.identity)as GameObject;	
		}

		if (personagem.renderer.bounds.Intersects(objeto1.renderer.bounds)) {
			Debug.Log ("Ponto!");
		}
	
	}
}





