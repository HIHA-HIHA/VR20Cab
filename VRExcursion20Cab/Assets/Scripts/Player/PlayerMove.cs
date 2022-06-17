
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody player;

    [SerializeField]
    private float speed;

    private void Awake()
    {
        if(player == null)
        {
            player = gameObject.GetComponent<Rigidbody>();
        }
    }

    private void FixedUpdate()
    {
        player.velocity = Vector3.zero;
        player.velocity =  GetDirection() * speed * Time.deltaTime;
    }

    private Vector3 GetDirection()
    {
        var rightDirection = Input.GetAxis("Horizontal");
        var forwardDirection = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * rightDirection + transform.forward * forwardDirection;
        return direction;
    }
}
