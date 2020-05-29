#pragma strict
var timer : float = 0;
var se_puede_pulsar_w : boolean;
var se_puede_pulsar_s : boolean;
var se_puede_pulsar_d : boolean;
var se_puede_pulsar_a : boolean;
function Start (){
se_puede_pulsar_w = true;
se_puede_pulsar_s = true;
se_puede_pulsar_d = true;
se_puede_pulsar_a = true;
}

function Update () {
 	if(Input.GetKey("w") && se_puede_pulsar_w == true){ //al pulsar la w desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de timer
    	Caminando();
    	se_puede_pulsar_s = false;
        se_puede_pulsar_d = false;
		se_puede_pulsar_a = false;
    	}
    if(Input.GetKeyUp ("w")){ //al dejar de pulsar la tecla w, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
    	Start();
    	timer = 0;
    
    }
 	if(Input.GetKey("s")&& se_puede_pulsar_s == true){ //al pulsar la s desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de timer
 		Caminando();
 		se_puede_pulsar_w = false;
        se_puede_pulsar_d = false;
		se_puede_pulsar_a = false;
 	}
 	if(Input.GetKeyUp ("s")){ //al dejar de pulsar la tecla s, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
    	Start();
    	timer = 0;
    	
    }
 	if(Input.GetKey("a")&& se_puede_pulsar_a == true){ //al pulsar la a desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de timer
 		Caminando();
 		se_puede_pulsar_s = false;
        se_puede_pulsar_d = false;
		se_puede_pulsar_w = false;
 	}
 	if(Input.GetKeyUp ("a")){ //al dejar de pulsar la tecla a, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
    	Start();
    	timer = 0;
    	
    }
 	if(Input.GetKey("d")&& se_puede_pulsar_d == true){ //al pulsar la d desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de timer
 		Caminando();
 		se_puede_pulsar_s = false;
        se_puede_pulsar_w = false;
		se_puede_pulsar_a = false;
 	}
 	if(Input.GetKeyUp ("d")){ //al dejar de pulsar la tecla d, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
    	timer = 0;
    	Start();
    	
    }
}
//mi funcion de anim
function Caminando (){	
	timer += Time.deltaTime;
	if (timer < 1){		
		animation.Play("");
	}
	if (timer > 1){
		animation.Play("");
	}
	if (timer >= 2){
		timer = 0;
	}
}

