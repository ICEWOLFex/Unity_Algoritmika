using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        //���������� �������
        gameObject = GameObject.Find("Primetive");
        //����������� �������
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
