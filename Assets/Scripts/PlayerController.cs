using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal_input_speed;
    [SerializeField] float speed;
    [SerializeField] BombController bomb;
    private void Update()
    {
        HorizontalInputSpeed();

        Shoot();
    }
    private void HorizontalInputSpeed()
    {
        horizontal_input_speed = Input.GetAxisRaw("Horizontal");
        //player movement either left or right.
        PlayerHorizontalMovement(horizontal_input_speed);
    }
    private void PlayerHorizontalMovement(float horizontal_input_speed)
    {
        Vector3 position = transform.position;
        position.x += horizontal_input_speed * speed * Time.deltaTime;
        transform.position = position;
    }

    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 player_pos = transform.position;
            Vector3 bomb_pos = new Vector3(player_pos.x, player_pos.y - 0.5f, player_pos.z);
            Instantiate(bomb, bomb_pos, Quaternion.identity);
        }
    }
}
