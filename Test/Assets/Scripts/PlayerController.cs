using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D mybody;

    public float speed;

    public float jumpPower;

    private bool canjump;
    void Start()
    {
        mybody = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        mybody.velocity = new Vector2(move * speed, mybody.velocity.y);
    }
}