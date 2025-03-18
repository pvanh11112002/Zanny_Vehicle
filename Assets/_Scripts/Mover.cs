using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Config in editor")]
    [SerializeField] float xValues = 0;
    [SerializeField] float yValues = 0;
    [SerializeField] float zValues = 0;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(xValues, yValues, zValues);
    }
}
