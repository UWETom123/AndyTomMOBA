using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public Vector2 influence;
    float jumpHeight = 10.0f;
    LayerMask layer;
    RaycastHit2D hit2D;
    public int jumps = 2;
    public int jumpsLeft = 2;

    void Start() //Use this for initialization
    {
        //Grabbing environment layer mask
        layer = LayerMask.GetMask("Environment"); 
    }

    void Update() //Update is called once per frame
    {
        //raycasting downwards to detect platforms
        hit2D = Physics2D.Raycast(GetComponent<Rigidbody2D>().position - new Vector2(0f, 0.4f), Vector2.down, 0.2f, layer);
        Movement();   
    }

    void Movement() //"Tidy up" fuction to keep all movement logic in one place
    {
        //grabbing velocity of rigidbody
        influence = GetComponent<Rigidbody2D>().velocity;

        //Handling left and right movement
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-0.07f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(0.07f, 0.0f, 0.0f);
        }

        //Resetting jumps if the player is on the ground
        if (hit2D)
        {
            jumpsLeft = jumps;
        }

        //if W or space is pressed, take one jump from jumpsLeft and set the influence
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            influence.y = jumpHeight;

            //if the player still has jumps left, then jump
            if (jumpsLeft > 0)
            {
                GetComponent<Rigidbody2D>().velocity = influence;
                jumpsLeft--;
            }
        }        
    }
}
