using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public HealthBar healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    public float moveSpeed;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Start() {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() 
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(gameObject.name + " collided with " + col.tag);
        if (col.tag == "Enemy"){
        GameObject other = col.gameObject;

        Debug.Log(other.name);

        currentHealth = currentHealth - other.GetComponent<EnemyMovement>().damageValue;

        healthBar.setHealth(currentHealth);
        Destroy(col.gameObject, 0);
        }
        
    }
}
