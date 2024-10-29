using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraDePassagens : MonoBehaviour
{
    public GameObject SelecionarPaises;
    public GameObject SelecionarHorario;

    public void SelecaoHorario()
    {
        Debug.Log("Método SelecaoHorario chamado");
        SelecionarHorario.SetActive(false);
        SelecionarPaises.SetActive(true);
    }

    public void SelecaoPaises()
    {
        Debug.Log("Método SelecaoPaises chamado");
        SelecionarHorario.SetActive(true);
        SelecionarPaises.SetActive(false);
    }

    void Start()
    {
        Debug.Log("Iniciando estado dos GameObjects");
        SelecionarHorario.SetActive(false);
        SelecionarPaises.SetActive(true);
    }

    void Update()
    {
        
    }
}
