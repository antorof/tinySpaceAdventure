﻿#pragma strict

var sistemaParticulas : ParticleSystem;
var cohete : GameObject;

function Start () {

}

function Update () {
    var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
    var hit : RaycastHit;
	var ok = collider.Raycast (ray, hit, 100.0F); // el 3er param es la profundidad

    if (ok) {
    	if (Input.GetMouseButton(0)) {
			cohete.transform.Translate(0,0.2,0);
	    	sistemaParticulas.emissionRate = 20;
    	}
	    else {
	    	sistemaParticulas.emissionRate = 7;
	    }
    }
}