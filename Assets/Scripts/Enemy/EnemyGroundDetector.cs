using UnityEngine;

public class EnemyGroundDetector : MonoBehaviour
{
    [SerializeField] private Transform _enemyTransform;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _enemyTransform.position = new Vector3(_enemyTransform.position.x, collision.GetContact(0).point.y, _enemyTransform.position.z);
    }
}
