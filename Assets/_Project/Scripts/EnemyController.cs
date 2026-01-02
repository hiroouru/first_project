using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 6f; // 적 이동 속도
    private Transform player; // 플레이어 위치 저장용

    void Start()
    {
        // 게임 시작하면 "Player"라는 이름 가진 놈을 찾아서 기억해라
        GameObject target = GameObject.Find("Player");
        if (target != null)
        {
            player = target.transform;
        }
    }

    void Update()
    {
        // 플레이어를 찾았으면 계속 쫓아가라
        if (player != null)
        {
            // MoveTowards: 내 위치에서 -> 플레이어 위치로 -> 조금씩 이동
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}