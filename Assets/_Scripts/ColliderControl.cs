using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    int colliderCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            colliderCount++;
            collision.gameObject.tag = "Hit";
            Debug.Log($"Collider Count: {colliderCount}");
        }
        
        

    }
}
