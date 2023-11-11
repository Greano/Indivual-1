using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TipCalculator : MonoBehaviour
{
    public int TipTotal = 0;
    public float tipPercent = .2F;
    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayMessage()
    {
        float tipamount = tipPercent * TipTotal;
        int tiptip = (int) tipamount + TipTotal;
        float div = 5 / 2;
        float conversion = (float)div;
        TextMeshPro.text = $"{div}";
    }
}
