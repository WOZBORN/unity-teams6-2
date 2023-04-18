using UnityEngine;

public class Saw : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }

}
