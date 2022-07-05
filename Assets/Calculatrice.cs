using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculatrice : MonoBehaviour
{
    public double Resultat = 0;
    public double OperandeInput = 0;
    public bool ShowOperande;
    public string Operation;
    public bool Coma = false;
    public double Div = 1;
    public TextMeshProUGUI Text;

    public void AddChiffre(int chiffre)
    {
        double div = 1;

        if (ShowOperande)
        {
            if (Coma)
            {
                Div *= 0.1;
                div = Div;
            }
            else
            {
                OperandeInput *= 10;
            }

            
            OperandeInput += chiffre * div;
            Display(OperandeInput);
        }
        else
        {
            if (Coma)
            {
                Div *= 0.1;
                div = Div;
            }
            else
            {
                Resultat *= 10;
            }
            
            Resultat += chiffre * div;
            Display(Resultat);
        }
    }

    public void Operande(string input)
    {
        Operation = input;
        ShowOperande = true;
        OperandeInput = 0;
        Div = 1;
        Coma = false;
        Display(OperandeInput);
    }

    public void Display(double nbr)
    {
        Text.text = nbr.ToString();
    }

    public void Calcul()
    {
        switch (Operation)
        {
            case "+":
                Resultat += OperandeInput;
                break;

            case "-":
                Resultat -= OperandeInput;
                break;

            case "x":
                Resultat *= OperandeInput;
                break;
        }

        ShowOperande = false;
        Display(Resultat);
    }

    public void AC()
    {
        Resultat = 0;
        ShowOperande = false;
        Operation = "";
        OperandeInput = 0;
        Div = 1;
        Coma = false;
        Display(Resultat);
    }

    public void AddComa()
    {
        Coma = true;
    }
}
