using UnityEngine;
using Photon.Pun;

public class SpaceshipMovement : MonoBehaviourPun
{
    public float moveSpeed = 6.5f;
    private Rigidbody2D rb;

    public GameObject Mark;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Check if this PhotonView is controlled by the local player
        if (!photonView.IsMine) return;

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 input = new Vector2(moveX, moveY).normalized;


        rb.MovePosition(rb.position + input * moveSpeed * Time.fixedDeltaTime);
    }
}
