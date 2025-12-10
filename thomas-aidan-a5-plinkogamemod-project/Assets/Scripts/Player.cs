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
        if (Input.GetButtonDown("Fire1") && activeDisc == null)
        {
            if (discsLeft == null)
            {
                Debug.LogError("[Player] discsLeft reference is null! Assign it in the Inspector.", this);
                return;
            }

            if (discsLeft.discs <= 0)
            {
                Debug.Log("[Player] Tried to drop but no discs left.");
                return;
            }

            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activeDisc = Instantiate(disc, position, rotation);
            cameraFollow?.FollowDisc(activeDisc);

            discsLeft.SubDiscs(1);
        }
    }
}
