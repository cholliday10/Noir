using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCoin : MonoBehaviour
{

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 5f);
    }

   private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            Destroy(this.gameObject);
            whatDidIHit.GetComponent<GameManager>().AddScore(1);
         


        }
    }
}
