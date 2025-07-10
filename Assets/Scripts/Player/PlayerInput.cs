using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public const string HorizontalAxis = nameof(Horizontal);
    public const string VerticalAxis = nameof(Vertical);

    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public void Update()
    {
        Horizontal = Input.GetAxis(HorizontalAxis);
        Vertical = Input.GetAxis(VerticalAxis);
    }
}
