using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SetColor(Color.blue);
    }
    private void OnTriggerExit(Collider other)
    {
        SetColor(Color.red);
    }
    private void OnTriggerStay(Collider other)
    {
        float num = Random.Range(0f, 1);
        float num1 = Random.Range(0f, 1);
        float num2 = Random.Range(0f, 1);

        SetColor(new Color(num,num1,num2));
    }
    private void SetColor(Color color)
    {
        Material mat = GetComponent<Renderer>().material;
        mat.color = color;
    }
}
