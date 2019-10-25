using UnityEngine;

public class Collision : MonoBehaviour
{
    public FollowPlayer followPlayer;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Obtacle")
        {
            followPlayer.enabled = false;
        }
    }
}