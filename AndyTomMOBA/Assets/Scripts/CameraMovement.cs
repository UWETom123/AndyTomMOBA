using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject objectToFollow;
    Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.1f;

    void Start() //Use this for initialization
    {

    }

    void Update() //Update is called once per frame
    {
        //Moving the camera smoothly to the player
        transform.position = Vector3.SmoothDamp(transform.position, objectToFollow.transform.position, ref velocity, smoothTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10.0f);
    }
}