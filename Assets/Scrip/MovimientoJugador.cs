using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    // Referencia pública del Rigidbody.
    public Rigidbody rb;

    // Valores para cambiar.
    private float ratonYLimiteArriba = -15f;
    private float ratonYLimiteAbajo = 20f;
    private float jugadorVelocidadMovimiento = 10f;
    private float jugadorVelocidadRotacion = 1.8f;

    // Teclas.
    private KeyCode teclaDelante = KeyCode.W;
    private KeyCode teclaDetras = KeyCode.S;
    private KeyCode teclaDerecha = KeyCode.D;
    private KeyCode teclaIzquierda = KeyCode.A;

    // Variables para almacenar el valor de las entradas.
    private bool boolDelante;
    private bool boolDetras;
    private bool boolDerecha;
    private bool boolIzquierda;
    private float ratonX;
    private float ratonY;

    // Variables para almacenar la dirección del movimiento.
    private Vector3 valorDelante;
    private Vector3 valorDetras;
    private Vector3 valorDerecha;
    private Vector3 valorIzquierda;
    private Vector3 direccionMovimiento;

    private void Update()
    {
        // Comprobar qué teclas se están pulsando.
        boolDelante = Input.GetKey(teclaDelante);
        boolDetras = Input.GetKey(teclaDetras);
        boolDerecha = Input.GetKey(teclaDerecha);
        boolIzquierda = Input.GetKey(teclaIzquierda);

        // Obtener el valor del ratón.
        ratonX += Input.GetAxis("Mouse X");
        ratonY -= Input.GetAxis("Mouse Y");

        // Bloquear el valor del ratón.
        ratonY = ratonY < ratonYLimiteArriba ? ratonYLimiteArriba : ratonY;
        ratonY = ratonY > ratonYLimiteAbajo ? ratonYLimiteAbajo : ratonY;
    }

    private void FixedUpdate()
    {
        // Obtener valores de las direcciones.
        valorDelante = boolDelante ? transform.forward : Vector3.zero;
        valorDetras = boolDetras ? -transform.forward : Vector3.zero;
        valorDerecha = boolDerecha ? transform.right : Vector3.zero;
        valorIzquierda = boolIzquierda ? -transform.right : Vector3.zero;
        // Obtener dirección del movimiento.
        direccionMovimiento = new Vector3(valorDelante.x + valorDetras.x + valorDerecha.x + valorIzquierda.x,
            -0.1f,
            valorDelante.z + valorDetras.z + valorDerecha.z + valorIzquierda.z);

        // Aplicar la velocidad de movimiento en la dirección calculada.
        rb.velocity = direccionMovimiento.normalized * jugadorVelocidadMovimiento;

        // Aplicar la rotación.
        transform.rotation = Quaternion.Euler(ratonY * jugadorVelocidadRotacion, ratonX * jugadorVelocidadRotacion, 0f);
    }
}