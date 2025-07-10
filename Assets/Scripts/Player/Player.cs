using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerMover _mover;

    private void Update()
    {
        _mover.Move(_input.Vertical, _input.Horizontal);
    }
}
