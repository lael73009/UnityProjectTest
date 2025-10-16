using UnityEngine;

public class pipeScript : MonoBehaviour
{
    public float moveSpeed;
    private float deadZone = -8.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        bool dead = transform.position.x < deadZone;
        if (dead)
        {
            //Debug.Log(" DELETED (" + transform.position.x + ")");
            Destroy(gameObject);
        }
        else
        {
            //Debug.Log("    not deleted (" + transform.position.x + ")");
        }
    }
}
