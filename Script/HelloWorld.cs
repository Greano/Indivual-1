using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public string firstName;
    public string lastName;

    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        TextMeshPro = GetComponent<TextMeshProUGUI>();
        TextMeshPro.text = $"Hello {firstName} {lastName}!"; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
