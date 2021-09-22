using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroup : MonoBehaviour
{

    public float distanceToMoveRight;
    public float distanceToMoveDown;
    public float timeToMove;
    public float nextTimeToMove;
    public float speedModifier;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToMove)
        {
            timeToMove = Time.time + nextTimeToMove;
            transform.position += new Vector3(distanceToMoveRight, 0, 0);
        }
        
        if(transform.position.x > 0.72f)
        {
            var position = transform.position;
            position = new Vector3(-0.72f, position.y + distanceToMoveDown, 0);
            transform.position = position;
        }
    }
}
