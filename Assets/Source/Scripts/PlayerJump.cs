using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;

    private void Awake() => _rigidbody2D = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TryJump();
    }

    private void TryJump() => _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
}