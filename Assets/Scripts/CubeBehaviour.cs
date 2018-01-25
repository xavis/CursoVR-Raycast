using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

	public void ChangeColor() { //FUNCION PARA CAMBIAR COLOR
		this.GetComponent<MeshRenderer>().material.color = Random.ColorHSV ();
		MeshRenderer renderer = this.GetComponent<MeshRenderer> ();
	}

}
