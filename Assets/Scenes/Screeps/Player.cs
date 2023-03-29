using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;//Velocidad Movimiento del jugador 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis('Horizontal'); //Obtiene el valor de Entrada horizontal
        transform.position += new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime; // Mueve al jugador en la direccion horizontal

        float verticalInput = Input.GetAxis('Vertical'); // Obtiene el valor de entrada vertical (Arriba, abajo) de las teclas W y S o las felchas arriba y abajo del teclado
        transform.position += new Vector3(0f, 0f,verticalInput) * speed * Time.deltaTime; // Mueve al jugador en la direccion vertical


    }
}
