using UnityEngine;

[RequireComponent (typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerMovement : MonoBehaviour
{
    public const string Horizontal = nameof(Horizontal);
    public const string Run = nameof(Run);

    [SerializeField] private float _speed;

    private float _horizontalInput;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update() => Move();

    private void Move()
    {
        FlipPlayer();
        _horizontalInput = Input.GetAxis(Horizontal);
        float direction = _horizontalInput * _speed * Time.deltaTime;
        transform.Translate(Vector2.right * direction);

        if(_horizontalInput > 0 || _horizontalInput < 0)
            _animator.SetBool(Run, true);
        else
            _animator.SetBool(Run, false);
    }

    private void FlipPlayer()
    {
        if (_horizontalInput < 0)
            _spriteRenderer.flipX = true;
        else
            _spriteRenderer.flipX = false;
    }
}