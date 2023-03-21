using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public SpriteRenderer sr;

    float distance;
    void Start()
    {
        
    }

    void Update()
    {
        distance = transform.position.x - player.position.x;

        Debug.Log(Mathf.Abs(distance));
        if (Mathf.Abs(distance) < 10)
        {
            StartCoroutine(enemyHold());

        }
    }
    IEnumerator enemyHold()
    {
        yield return new WaitForSeconds(1);
        if(transform.position.x > player.position.x)
        {
                
            sr.flipX = true;
            if(distance < 2)
            {
                
            }
            else
            {
                transform.Translate(new Vector2(-0.02f, 0));
            }
            
        }
        if (transform.position.x < player.position.x)
        {
            sr.flipX = false;
            if (distance < 2)
            {
                
            }
            else
            {
                transform.Translate(new Vector2(0.2f, 0));
            }
            
                
        }
    }
}
