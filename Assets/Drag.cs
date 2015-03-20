using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {
		Vector3 dist;
		float posX;
		float posY;
		
		void OnMouseDown(){
				dist = Camera.main.WorldToScreenPoint(transform.position);
				posX = Input.mousePosition.x - dist.x;
				posY = Input.mousePosition.y - dist.y;
				
			}
		
		void OnMouseDrag(){
				Vector3 curPos = 
						new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);  
				
					Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
				transform.position = worldPos;
			}

	void OnCollisionEnter2D(Collision2D collision){
		
		
		Tipo tipoDoElemento = collision.gameObject.GetComponent<Tipo>();
		
		if(tipoDoElemento != null){
			
			if((tipoDoElemento.tipo == Tipo.Elemento.Tiro)){

				Application.LoadLevel("Scene5");
				
			}
			
		}
	}

	}