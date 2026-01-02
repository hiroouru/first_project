using UnityEngine;

public class TopDownController : MonoBehaviour
{
    // 속도 (Inspector에서 조절 가능하게 public으로 설정)
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // 내 몸에 달린 Rigidbody 2D 컴포넌트를 찾아서 가져와라
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. 키보드 입력을 감지한다 (방향키 또는 WASD)
        // Horizontal: A(-1), D(+1) / Vertical: S(-1), W(+1)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // 2. 물리 엔진을 이용해 위치를 이동시킨다
        // 현재 위치 + (방향 * 속도 * 시간)
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}