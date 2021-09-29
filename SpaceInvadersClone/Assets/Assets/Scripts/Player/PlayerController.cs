using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    public float fireRate;
    public float timeToShoot;

    public Transform shooter;
    public GameObject bulletPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerShoot();
    }

    void PlayerMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(moveX, moveY, 0f).normalized;
        
        //Debug.Log(move);

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    void PlayerShoot()
    {

        GameObject bullet = ObjectPooling.SharedInstance.GetPooledObject();
        
        if (Input.GetKey(KeyCode.Space) && Time.time > timeToShoot)
        {
            timeToShoot = Time.time + fireRate;
            //Instantiate(bulletPrefab, shooter.position, Quaternion.identity);
            if (bullet!= null)
            {
                bullet.transform.position = shooter.position;
                bullet.SetActive(true);
            }
            
        }
        
        
    }
}
