using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float walkSpeed;
    [Header("Player Properties")]
    public static Transform spawnPoint;
    public float rotacaoSpeed = 720;
    private Rigidbody2D rb;
    public bool canMove = true;
    public static PlayerController player;
    public InventoryHandler inventory;
    public Transform defaultSpawn;
    private Animator animator;
    private Vector2 input;
    private Vector2 lastMove;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        if (PlayerPrefs.HasKey("SpawnMudado")) {
            float x = PlayerPrefs.GetFloat("PositionX");
            float y = PlayerPrefs.GetFloat("PositionY");
            float z = PlayerPrefs.GetFloat("PositionZ");
            Vector3 newSpawn = new Vector3(x, y, z);
            this.gameObject.transform.position = newSpawn;
        }
        
        
    }



    void Update()
    {

        if (canMove)
        {
            HandleMovement();
            Animate();
        }

    }

    void HandleMovement()
    {
        float x0 = Input.GetAxisRaw("HORIZONTAL0");
        float y0 = Input.GetAxisRaw("VERTICAL0");

        if ((x0 == 0 && y0 == 0) && (input.x != 0 || input.y != 0))
            lastMove = input;

        input.x = Input.GetAxisRaw("HORIZONTAL0");
        input.y = Input.GetAxisRaw("VERTICAL0");
        input.Normalize();
        rb.velocity = input * walkSpeed;
    }

    void Animate() {

        animator.SetFloat("walkX", input.x);
        animator.SetFloat("walkY", input.y);
        animator.SetFloat("moveMagnitude", input.magnitude);
        animator.SetFloat("lastX", lastMove.x);
        animator.SetFloat("lastY", lastMove.y);

    }
}
