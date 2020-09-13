using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static readonly Vector3 moveDown = new Vector3(0.0f, -3.0f, 0.0f);
    public static readonly Vector3 moveUp = new Vector3(0.0f, 5.0f, 0.0f);
    public Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);
    public static readonly float MaxDownSpeed = -7.0f;

    // Start is called before the first frame update
    void Start()
    {
        ApplyVelocity();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
        ApplyVelocity();
        SetVelocityYLimit();
    }

    private void ApplyVelocity()
    {
        Rigidbody rbody = GetComponent<Rigidbody>();
        UnityEngine.Assertions.Assert.IsNotNull(rbody);
        rbody.velocity = velocity;
    }

    private void MoveDown()
    {
        MergeVelocity(out velocity, velocity, moveDown);
    }

    private void SetVelocityYLimit()
    {
        if (velocity.y < MaxDownSpeed)
        {
            velocity.y = MaxDownSpeed;
        }
    }

    private void MoveJump()
    {
    }

    private void MergeVelocity(out Vector3 mergeResult, Vector3 merge1, Vector3 merge2)
    {
        mergeResult = merge1 + merge2;
    }
}
