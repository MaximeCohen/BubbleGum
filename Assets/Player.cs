using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private Rigidbody2D player;
    bool facingRight = true;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void turnBody()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    // Update is called once per frame
    void Update()
    {

        //float move = Input.GetAxis("Horizontal");

        //GetComponent<Rigidbody2D>().velocity = new Vector2(move * 10f, GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.position = new Vector2(player.position.x + 0.1f, player.position.y);
            if (!facingRight)
                turnBody();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.position = new Vector2(player.position.x - 0.1f, player.position.y);
            if (facingRight)
                turnBody();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.AddForce(transform.forward);
        }
    }
}