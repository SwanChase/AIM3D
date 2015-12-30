using UnityEngine;
using System.Collections;

public class ObjectLauncher : MonoBehaviour
{
    public GameObject obj;
    public int cooldown;
    public float ballSpeed;
    //public float spreadFactor = 0.02f;
    private int _counter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _counter--;
        if (_counter <= 0)
        {
            GameObject ball = Instantiate(obj, transform.position, transform.rotation) as GameObject;
            ball.GetComponent<Rigidbody>().AddForce(transform.up * ballSpeed, ForceMode.Impulse);
            _counter = cooldown;
        }
    }
}
