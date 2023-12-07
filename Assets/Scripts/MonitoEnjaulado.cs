using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitoEnjaulado : MonoBehaviour
{
    public GameObject pantallawinii;

    // Start is called before the first frame update
    void Start()
    {
        pantallawinii.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pantallawinii.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
