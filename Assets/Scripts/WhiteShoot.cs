using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class WhiteShoot : MonoBehaviour
{

    private PlayerMove playerMove;
    public Transform rotate;
    [SerializeField] private GameObject Gun;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform BulletSpawn;
    private InputSystem_Actions inputActions;
    InputAction fire;
    private PlayerInput playerInput;
    private bool Shoot;
    private GameObject bulletinst;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        playerInput = GetComponent<PlayerInput>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions.Player.Attack.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        aim();
        
        GunShooting();
        Shoot = false;

    }

    public void aim()
    {
        float HorizontalAxis = Input.GetAxis("horizontalrighstick");
        float VerticalAxis = Input.GetAxis("verticalrightstick");

        rotate.transform.localEulerAngles = new Vector3(0f, 0f, Mathf.Atan2(HorizontalAxis, VerticalAxis) * -180 / Mathf.PI + 90);
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Shoot = true;

        
    }

    private void GunShooting()
    {
        if (Shoot)
        {
            bulletinst = Instantiate(Bullet, BulletSpawn.position, Gun.transform.rotation);
        }
    }

    private void OnEnable()
    {
        fire = inputActions.Player.Attack;
        fire.Enable();
        fire.performed += Fire;
    }

    private void OnDisable()
    {

        fire.Disable();
    }
}
