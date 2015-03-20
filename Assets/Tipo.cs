using UnityEngine;
using System.Collections;

public class Tipo : MonoBehaviour {
	
	public enum Elemento
	{
		Chao,
		Personagem,
		FimTelaTiro,
		FimTelaObjetos,
		Tiro,
		Inimigos
	}
	
	public Elemento tipo;
	
}