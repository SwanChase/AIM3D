using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour
{
    public float lifetime;

    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
