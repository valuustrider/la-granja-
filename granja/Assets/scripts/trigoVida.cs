using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class trigoVida : MonoBehaviour
{
    int estado;
    Animator animator;
    float tiempoespera = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }
    private IEnumerator CambiarEstado()
    {
        while (estado < 4)
        {
            animator.SetInteger("estado", estado);
            estado++;
            yield return new WaitForSeconds(tiempoespera);
        }
    }


}