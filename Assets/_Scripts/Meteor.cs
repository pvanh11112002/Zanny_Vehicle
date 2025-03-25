using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        rb.useGravity = false;
        meshRenderer.enabled = false;
    }
    private void Update()
    {
        if(Time.time > 3)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
