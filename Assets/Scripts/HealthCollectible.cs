using UnityEngine;

public class HealthCollectible : MonoBehaviour 
{
    public GameObject pickupParticle;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);

            GameObject pickupParticleObject = Instantiate(pickupParticle, transform.position, Quaternion.identity);
        }
    }
}
