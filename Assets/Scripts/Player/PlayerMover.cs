using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed;
    [SerializeField] private float _straightSpeed;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    public void Move(float vertical, float horizontal)
    {
        Vector3 forward = _transform.forward * vertical;
        Vector3 straight = _transform.right * horizontal;
        Vector3 motion = ((forward.normalized * _speed) + (straight.normalized * _straightSpeed)) * Time.deltaTime;
        motion.y = Physics.gravity.y;

        _characterController.Move(motion);
    }
}
