using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    public Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr;

    private void Update()
    {
        // Prevent any movement or action while dashing
        if (isDashing)
        {
            return;
        }

        // Get horizontal movement input
        horizontal = Input.GetAxisRaw("Horizontal");

        // Update animator with movement speed
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        // Jump logic
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        // Cut jump height if the jump button is released early
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.8f);
        }

        // Dash input logic
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

        // Handle flipping the character based on movement direction
        Flip();
    }

    private void FixedUpdate()
    {
        // Prevent movement during dash
        if (isDashing)
        {
            return;
        }

        // Apply horizontal movement
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    // Check if player is grounded
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    // Flip the player based on direction
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    // Handle dash mechanics
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f; // Temporarily remove gravity during the dash
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true; // Enable trail effect during dash
        yield return new WaitForSeconds(dashingTime); // Dash duration
        tr.emitting = false;
        rb.gravityScale = originalGravity; // Restore gravity
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown); // Cooldown time before next dash
        canDash = true;
    }
}
