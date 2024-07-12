using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class input : MonoBehaviour
{
    [SerializeField] TMP_InputField main;
    [SerializeField] TMP_InputField second;
    string maintext = "";
    string secondtext = "";
    string operationtext = "";
    [SerializeField] TextMeshProUGUI operation;
   
    void Start()
    {
       
    }

    
    void Update()
    {
       main.text = maintext;
       operation.text = operationtext;
       second.text= secondtext;
        
    }

    public void Erase()
    {
        maintext = "";
        
    }

    public void nuber(string value)
    {
        maintext += value;
        
    }
    public void operationvalu(string symbol)
    {
        operationtext = symbol;
    }

    public void add()
    {
        if (secondtext == "")
        {
            secondtext = maintext;
        }
        else
        {
            int finalsum = int.Parse(secondtext) + int.Parse(maintext);
            secondtext = finalsum.ToString() ;
        }
       
        // main text is equal tp zero 
        Erase();
    }
    public void multiple()
    {
        if (secondtext == string.Empty)
        {
            secondtext = maintext;
        }
        else
        {
            int finalsum = int.Parse(secondtext) * int.Parse(maintext);
            secondtext = finalsum.ToString();
        }

        Erase();
    }
    public void subtraction()
    {
        if (secondtext == string.Empty)
        {
            secondtext = maintext;
        }
        else
        {
            int finalsum = int.Parse(secondtext) - int.Parse(maintext);
            secondtext = finalsum.ToString();
        }

        Erase();
    }
    public void divide()
    {
        if (secondtext == string.Empty)
        {
            secondtext = maintext;
        }
        else
        {
            int finalsum = int.Parse(secondtext) / int.Parse(maintext);
            secondtext = finalsum.ToString();
        }

        Erase();
    }

}
