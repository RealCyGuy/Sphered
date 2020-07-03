using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    GameObject particle;
    private void Awake() {
        Destroy(gameObject, Random.Range(7.0f, 13.0f));
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
