using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;

    private void Start()
    {
        Destroy(gameObject, 7);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
    }
}
