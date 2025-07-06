using UnityEngine;

public class Player : MonoBehaviour, IMovable
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed;
    [SerializeField] private float _straightSpeed;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 forward = _transform.forward * _input.Vertical;
        Vector3 straight = _transform.right * _input.Horizontal;
        Vector3 motion = (forward.normalized * _speed * Time.deltaTime) + (straight.normalized * _straightSpeed * Time.deltaTime);
        motion.y = Physics.gravity.y;

        _characterController.Move(motion);
    }
}
