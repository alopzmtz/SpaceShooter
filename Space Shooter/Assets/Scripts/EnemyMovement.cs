using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed;

    public float height = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
           
        position = new Vector2(position.x + (-speed * Time.deltaTime), position.y + Random.Range(-speed, speed) * Time.deltaTime);

        transform.position = position;

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
  

        if (transform.position.x < max.x) {
            Destroy(gameObject);
        }
    }
}