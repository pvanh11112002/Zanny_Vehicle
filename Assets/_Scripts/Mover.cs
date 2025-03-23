using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Config in editor")]
    [SerializeField] float speed = 10;
    [SerializeField] Vector3 input = Vector3.zero;
    void Update()
    {
        input.x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        input.y = 0;
        input.z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(input);
        //if(input != Vector3.zero)
        //{
            
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(input), Time.deltaTime * 5f);
        //}
            
    }
}
