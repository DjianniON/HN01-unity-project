using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BotSphere"))
        {
            
            Renderer rendOther = other.GetComponent<Renderer>();
            if (rendOther.material.color != Color.red)
            {
                Renderer rend = this.GetComponent<Renderer>();
                rend.material.color = rend.material.color + Color.red;               
                rendOther.material.color = Color.red;
            }
        }
    }
}
