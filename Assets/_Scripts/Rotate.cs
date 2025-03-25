using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Vector3 rotateVal;
    private void Update()
    {
        transform.Rotate(rotateVal);
    }
}
