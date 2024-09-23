using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TheCalculator : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public TextMeshProUGUI historial;
    public List<string> lines = new List<string>();

    public static string currentInput = "";
    private void Start()
    {
        //lines.Add("HOla");

    }
    private double result = 0.0;
    public void Update()
    {
        UpdateDisplay();
        if (OnShootEqual.equallActivated) 
        {
            Calculateresult();
        }
    }
    //Lo siguiente lo saqué de la calculadora que tuvimos en el segundo cuatri, esto calcula el resultado de la operacion que se escribió
    public void Calculateresult()
    {
        try
        {
            result = System.Convert.ToDouble(new System.Data.DataTable().Compute(currentInput, ""));

            currentInput = result.ToString();
            //lines.Add(currentInput);
            UpdateDisplay();

        }
        catch (System.Exception)
        {
            currentInput = "Error";
            UpdateDisplay();
        }
    }
    private void UpdateDisplay()
    {
        displayText.text = currentInput;
        //historial.text += lines[0];
    }
}
