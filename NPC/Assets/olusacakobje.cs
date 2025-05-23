using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olusacakobje : MonoBehaviour
{
    public int carpmasayisi = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("dusman")) {
            if (carpmasayisi != 0)
            {
                carpmasayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    
}
