using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaramelitodeLimonconsal : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Te toqué " + collision.gameObject.name);

        if (collision.gameObject.tag == "Player" && gameObject.CompareTag("Enemigo"))
        {
            player = collision.gameObject;
            PlayerHealthController.instance.AnimMuerte();
            player.GetComponent<Movement>().Desactivate();
            Debug.Log("Te quito vida");
            AudioManager.instance.PlayDead();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
