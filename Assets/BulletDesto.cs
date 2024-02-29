using UnityEngine;

public class BulletDestro : MonoBehaviour
{
    [SerializeField] private float destroy = 3f;

    private void Start()
    {
        Destroy(gameObject, destroy);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
