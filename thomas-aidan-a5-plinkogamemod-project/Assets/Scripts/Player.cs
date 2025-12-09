using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject disc;
    public CameraFollow cameraFollow;
    private GameObject activeDisc;
    public int dispense = 5;
    public DiscsLeft discsLeft;

    // Update is called once per frame
    void Update()
    {
        Move();
        DropDisc();
    }

    void Move()
    {
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }

    void DropDisc()
    {
        // Don't drop a disc if none are left
        if (discsLeft.discs <= 0)
            return;

        if (Input.GetButtonDown("Fire1") && activeDisc == null)
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activeDisc = Instantiate(disc, position, rotation);
            cameraFollow.FollowDisc(activeDisc);
            discsLeft.SubDiscs(1);
        }
    }
}
