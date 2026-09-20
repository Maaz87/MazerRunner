using UnityEngine;

public class CollectibleSpin : MonoBehaviour
{
    public float spinSpeed = 120f;                      // degrees per second
    public Vector3 spinAxis = new Vector3(1f, 1f, 0f);  // tilted axis so the spin is visible

    void Update()
    {
        transform.Rotate(spinAxis, spinSpeed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<PlayerMovement>() != null)
        {
            Destroy(gameObject);
        }
    }
}