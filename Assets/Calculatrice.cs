using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculatrice : MonoBehaviour
{
    public int Resultat = 0;
    public int OperandeInput = 0;
    public bool ShowOperande;
    public string Operation;
    public TextMeshProUGUI Text;

    public void AddChiffre(int chiffre)
    {
        if (ShowOperande)
        {
            OperandeInput *= 10;
            OperandeInput += chiffre;
            Display(OperandeInput);
        }
        else
        {
            Resultat *= 10;
            Resultat += chiffre;
            Display(Resultat);
        }
    }

    public void Operande(string input)
    {
        Operation = input;
        ShowOperande = true;
        OperandeInput = 0;
        Display(OperandeInput);
    }

    public void Display(int nbr)
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
        Display(Resultat);
    }
}
