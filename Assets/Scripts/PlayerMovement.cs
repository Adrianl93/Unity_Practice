using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private float _horizontalDirection;
    public float speed = 4;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody2D;
    private Collider2D _collider;

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        Run();
    }

    private void Run()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");

        _rigidBody2D.linearVelocity = new Vector2(_horizontalDirection * speed, _rigidBody2D.linearVelocity.y);

        if (_horizontalDirection != 0)
        {
            _spriteRenderer.flipX = _horizontalDirection < 0;
        }
    }
}
