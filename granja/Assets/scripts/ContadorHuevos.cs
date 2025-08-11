using UnityEngine;
using UnityEngine.UIElements;

public class ContadorHuevos : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosAntes = -1;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }


    void Update()
    {
        if(GameManager.instancia.conteoHuevos != huevosAntes)
        {
            huevosAntes = GameManager.instancia.conteoHuevos;
            labelHuevos.text = $"Huevos: {huevosAntes}";
        }
        
    }
}