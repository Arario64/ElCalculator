using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TheCalculator : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    public static string currentInput = "";

    private double result = 0.0;
    public void Update()
    {
        UpdateDisplay();
        if (OnShootEqual.equallActivated) 
        {
            Calculateresult();
        }
    }
    public void Calculateresult()
    {
        try
        {
            result = System.Convert.ToDouble(new System.Data.DataTable().Compute(currentInput, ""));

            currentInput = result.ToString();
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
    }
}
