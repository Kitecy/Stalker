using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public void Update()
    {
        Horizontal = Input.GetAxis(nameof(Horizontal));
        Vertical = Input.GetAxis(nameof(Vertical));
    }
}
