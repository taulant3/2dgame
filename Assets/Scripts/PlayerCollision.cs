using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerScript movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
