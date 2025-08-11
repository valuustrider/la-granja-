using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public int conteoHuevos;



    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SumarHuevo()
    {
        conteoHuevos++;
        Debug.Log(conteoHuevos);
    }

}