using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/Orienta/EscribirUsuarios.php";

    public int id = 1;
    private string nombre = "";
    

    public InputField campoNombre;


    public void SenData()
    {
        //es llamar a un metodo generando una pausa en la ejecución del programa hasta que se realiza lo que esta dentro del metodo
        StartCoroutine(enviarDatosUsuario());
    }

    private IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;        


        print(id + "  " + nombre);


        if (nombre == "")
        {
            print("El campo de nombre debe tener información");
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("identificacion", id);
            form.AddField("nombre", nombre);
            

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);

        }



    }
}