
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpforce;
    private SpriteRenderer sprite;
    public float speed;
    public Animator animator;

    public float score = 0;
    public Text scoreText;
    public GameObject menu;
    public GameObject finishWindow;
    public GameObject educationText1;
    public GameObject educationText2;
    public GameObject educationText3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pickup"))
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }

        if (collision.CompareTag("Finish"))
        {
            finishWindow.SetActive(true);
        }

        if (collision.CompareTag("Education1"))
        {
            educationText1.SetActive(false);
        }

        if (collision.CompareTag("Education1"))
        {
            educationText2.SetActive(true);
        }

        if (collision.CompareTag("Education2"))
        {
            educationText2.SetActive(false);
        }

        if (collision.CompareTag("Education2"))
        {
            educationText3.SetActive(true);
        }
        if (collision.CompareTag("EducationTextsOff"))
        {
            educationText3.SetActive(false);
        }
    }
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            animator.SetBool("isgoing", true);
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animator.SetBool("isgoing", true);
            sprite.flipX = false;
        }
        else
        {
            animator.SetBool("isgoing", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            animator.SetBool("isjump", true);
        }
        else
        {
            animator.SetBool("isjump", false);
        }  
        
        if (Input.GetKey(KeyCode.Escape))
        {
            menu.SetActive(true);
        }
    }


}
