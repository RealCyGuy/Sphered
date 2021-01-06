using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public KeyCode keyUp;
    public KeyCode keyLeft;
    public KeyCode keyDown;
    public KeyCode keyRight;
    private float speed = 0.6f;
    public bool playerOne;

    void FixedUpdate()
    {
        if (Input.GetKey(keyUp))
            GetComponent<Rigidbody>().velocity += new Vector3(speed, 0, 0);
        if (Input.GetKey(keyDown))
            GetComponent<Rigidbody>().velocity -= new Vector3(speed, 0, 0);
        if (Input.GetKey(keyLeft))
            GetComponent<Rigidbody>().velocity += new Vector3(0, 0, speed);
        if (Input.GetKey(keyRight))
            GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, speed);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Death")
        {
            if (playerOne)
            {
                Score.playerTwoScore += 1;
            }
            else
            {
                Score.playerOneScore += 1;
            }
            Debug.Log(Score.playerTwoScore);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.collider.tag == "Food")
        {
            transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
            GetComponent<Rigidbody>().mass += 5;
            if (speed > 0.2f)
                speed -= 0.04f;
        }
    }
}
