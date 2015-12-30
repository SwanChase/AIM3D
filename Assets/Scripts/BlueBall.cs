using UnityEngine;
using System.Collections;

public class BlueBall : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == Tags.Target)
        {
            other.gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}