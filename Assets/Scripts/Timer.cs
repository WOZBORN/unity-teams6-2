using UnityEngine;

public class Timer : MonoBehaviour
{
    public float speed;

    public float timer = 0;
    public float moveDuration = 2;

    public Vector2 direction = Vector2.left;
    void Update()
    {
        transform.Translate(direction* speed * Time.deltaTime);

        timer = timer + Time.deltaTime;
        
        if  (timer >= moveDuration)
        {
            direction = direction * -1;
            timer = 0;
        }
    }
}
