using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    [SerializeField] float moveSpeed = 350f;

    public int damageValue = 1;
    private Rigidbody2D rb;

    private void Awake() {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    private void Update() {

    }

    // Update is called once per frame
    private void FixedUpdate() {
        transform.position = Vector2.MoveTowards(rb.transform.position, player.GetComponent<Rigidbody2D>().transform.position, moveSpeed * Time.deltaTime);

    }

    private void OnDestroy() {
        Debug.Log("Alas, I've been slewn");
        transform.DetachChildren();
    }
}
