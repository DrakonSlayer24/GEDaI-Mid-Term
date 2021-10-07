using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoost : MonoBehaviour
{
    Rigidbody rigidbody;
    public float BoostDistance;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision PUCol)
    {
        Boost PU = PUCol.gameObject.GetComponent<Boost>();
        if (PU)
        {
            Destroy(PUCol.gameObject);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + BoostDistance);
        }
    }
}
