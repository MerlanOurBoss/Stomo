using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MakeInjection : MonoBehaviour
{
    [SerializeField] private bool hitDesna = false;
    [SerializeField] public Text myText;
    public Color hitColor;
    public Color missedColor;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Desna"))
        {
            hitDesna = true;
            Debug.Log("hitted");
            myText.text = "Hit";
            myText.color = Color.green;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Desna"))
        {
            hitDesna = false;
            Debug.Log("not hitted");
            myText.text = "Missed";
            myText.color = Color.red;
        }
    }
}
