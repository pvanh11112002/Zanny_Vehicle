using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 2.5f;
    private Vector3 playerPosition;
    private void Start()
    {
        
    }
    private void Update()
    {
        playerPosition = playerTransform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
}
