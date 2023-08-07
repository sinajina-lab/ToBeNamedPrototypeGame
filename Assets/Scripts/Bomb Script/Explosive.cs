using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.ParticleSystem;

public class Explosive : MonoBehaviour
{
    [SerializeField] float _triggerForce = .5f;
    [SerializeField] float _explosionRadius = 5;
    [SerializeField] float _explosionForce = 500;
    [SerializeField] GameObject _particles;

    [SerializeField] DeductPoints deductPointsScript;
    [SerializeField] CoinPicker coinPickerScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= _triggerForce)
        {
            Explode();
        }
    }

    private void Explode()
    {
        var surroundingObjects = Physics.OverlapSphere(transform.position, _explosionRadius);

        foreach (var obj in surroundingObjects)
        {
            var rb = obj.GetComponent<Rigidbody>();
            if (rb == null) continue;

            rb.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);

            // Check if the object has the CoinPicker script attached
            var coinPickerObj = obj.GetComponent<CoinPicker>();
            if (coinPickerObj != null)
            {
                // Add points to the object's script (CoinPicker)
                coinPickerObj.AddPoints();
            }
            else
            {
                // Check if the object has the DeductPoints script attached
                var deductPointsObj = obj.GetComponent<DeductPoints>();
                if (deductPointsObj != null)
                {
                    // Deduct points from the object's script (DeductPoints)
                    deductPointsObj.MinusPoints();
                }
            }
        }

        Instantiate(_particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}