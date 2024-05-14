using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 move;
    [SerializeField] Rigidbody2D _rb;

    void Start()
    {
        
    }

    
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(move.x, 0);
    } 
}
