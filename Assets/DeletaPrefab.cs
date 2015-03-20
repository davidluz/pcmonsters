using UnityEngine;
using System.Collections;

public class DeletaPrefab : MonoBehaviour {



	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("teste");
		
		Tipo tipoDoElemento = collision.gameObject.GetComponent<Tipo>();
		
		if(tipoDoElemento != null){
			
			if((tipoDoElemento.tipo == Tipo.Elemento.FimTelaObjetos)){
				Debug.Log ("colidiu!");
				Destroy(gameObject);  
				
			}
			
		}
	}




}
