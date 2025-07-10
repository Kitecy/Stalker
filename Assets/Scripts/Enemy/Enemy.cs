using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _distanceFromPlayer;

    private Rigidbody _rigidbody;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 direction = _target.position - _transform.position;

        if (direction.sqrMagnitude > _distanceFromPlayer * _distanceFromPlayer)
            Move(direction.normalized);
    }

    public void Move(Vector3 direction)
    {
        _rigidbody.MovePosition(_transform.position + direction * _speed * Time.fixedDeltaTime);
    }
}
