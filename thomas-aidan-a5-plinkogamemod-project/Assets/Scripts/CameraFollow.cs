using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public CameraFollow camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition;
        if (disc == null)
        {
            targetPosition = player.transform.position;
        }
        else
        {
            targetPosition = disc.transform.position;
        }
        targetPosition.x = 0;
        targetPosition.z = camera.transform.position.z;

        // Assigning camera pos partly from current to target pos
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, lerpRate);
    }

    public void FollowDisc(GameObject disc)
    { 
        this.disc = disc;
    }
}
