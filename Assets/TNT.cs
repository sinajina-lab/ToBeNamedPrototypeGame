using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    [SerializeField] float _triggerForce = .5f;
    [SerializeField] float _explosionRadius = 5;
    [SerializeField] float _explosionForce = 500;
    [SerializeField] GameObject _particales;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= _triggerForce)
        {
            var surroundingObjects = Physics.OverlapSphere(transform.position, _explosionRadius);

            foreach (var obj in surroundingObjects)
            {
                var rb = obj.GetComponent<Rigidbody>();
                if (rb == null) continue;

                rb.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
            }

            Instantiate(_particales, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
