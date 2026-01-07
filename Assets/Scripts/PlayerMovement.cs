using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 7;
    public Rigidbody2D rb;
    public Animator anim;

    // Update is called once per frame
    // FixedUpdate is called 50times per second
    void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        anim.SetFloat("horizontal", horizontal);
        anim.SetFloat("vertical", vertical);

        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }
}
