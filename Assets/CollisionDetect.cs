using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {
	public GameObject object1;
	public GameObject object2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (object1.renderer.bounds.Intersects(object2.renderer.bounds)) {
			Debug.Log ("Ponto!");

		}
	}
}

