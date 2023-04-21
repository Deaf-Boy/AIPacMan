using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public float speed = 8.0f;

    public float multiplyer = 1.0f;
    public Vector2 initialDirection;
    public LayerMask obsticaleLayer;

    public new Rigidbody2D rigidbody { get; private set; }
    public Vector2 direction { get; private set; }
    public Vector2 nextDirection { get; private set; }
    public Vector3 startingPosition { get; private set; }

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
        this.startingPosition = this.transform.position;
    }

    private void Start()
    {
        
    }

    public void ResetState()
    {
        this.multiplyer = 1.0f;
        this.direction = this.initialDirection;
        this.nextDirection = Vector2.zero;
        this.transform.position = this.startingPosition;
        this.rigidbody.isKinematic = false;
        this.enabled = true;

    }


    private void FixedUpdate()
    {
        Vector2 position = this.rigidbody.position;
        Vector2 translation = this.direction * this.speed * this.multiplyer * Time.fixedDeltaTime;
        this.rigidbody.MovePosition(position + translation);
    }

    public void Setdirection(Vector2 direction)
    { 
    
    }

    public bool occupied(Vector2 direction)
    {
        RaycastHit2D hit2D = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.75f, 0.0f, direction, 1.5f);
        return hit2D.collider != null;

    }
}
