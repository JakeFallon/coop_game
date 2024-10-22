using UnityEngine;
using UnityEngine.InputSystem;

public class BlackShoot : MonoBehaviour
{

    private PlayerMove playerMove;
    public Transform rotate;
    private Vector2 WorldPos;
    private Vector2 direction;
    private Vector2 GameObjectRotation;
    [SerializeField] private GameObject Gun;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform BulletSpawn;
    private bool Shoot;
    private GameObject bulletinst;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GunRotation();
        GunShooting();
    }

    private void GunRotation()
    {
        WorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = (WorldPos - (Vector2)Gun.transform.position).normalized;
        Gun.transform.right = direction;

    }

    private void GunShooting()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            bulletinst = Instantiate(Bullet, BulletSpawn.position, Gun.transform.rotation);
        }
        
    }


}
