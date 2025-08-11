using System;
using UnityEngine;
using Random =UnityEngine.Random;

public class GallinaMovimiento : MonoBehaviour
{
    public Transform areaMovimiento;
    public float velocidad;
    private Vector2 destino;
    public SpriteRenderer sr;
    Vector2 posicionActual;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        NuevoDestino();
        posicionActual = transform.position;
    }

    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, destino, velocidad* Time.deltaTime);

        Vector2 direccion = posicionActual - destino;
        Debug.Log("Direccion: " + direccion.x);

        if(direccion.x >= 0){
            sr.flipX = true; // ir a la izquierda
        }
        else
        {
            sr.flipX = false; // ir a la derecha
        }


        if(Vector2.Distance(transform.position,destino)<0.1f)
        {
            NuevoDestino();
            posicionActual = transform.position;
        }
    }

    void NuevoDestino()
    {
        Vector2 centro = areaMovimiento.position; 
        Vector2 tama�o = areaMovimiento.localScale;

        float x = Random.Range(centro.x - tama�o.x /2f , centro.x + tama�o.x/2f);
        float y = Random.Range(centro.y - tama�o.y /2f , centro.y + tama�o.y/2f);

        destino = new Vector2(x,y);

        Debug.Log(destino);
    }



}
