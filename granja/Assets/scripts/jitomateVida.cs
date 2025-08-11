using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class jitomateVida : MonoBehaviour
{
    int estado;
    Animator animator;
    float tiempoespera = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }
    private IEnumerator CambiarEstado()
    {
        while (estado < 5)
        {
            animator.SetInteger("estado", estado);
            estado++;
            yield return new WaitForSeconds(tiempoespera);

        }
    }
}