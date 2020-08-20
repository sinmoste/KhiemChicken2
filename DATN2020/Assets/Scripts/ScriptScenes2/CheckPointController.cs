using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Sprite sign;
    private SpriteRenderer checkpointrenderer;
    bool checkpointreder;
    // Start is called before the first frame update
    void Start()
    {
        checkpointrenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           // checkpointrenderer.sprite = sign;
          //  checkpointreder = true;
            checkpointrenderer.color = Color.red;
        }
    }
}
