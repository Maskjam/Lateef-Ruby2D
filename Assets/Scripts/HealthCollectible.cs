using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);

            controller.PlaySound(collectedClip);
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        

    }
}
