using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : MonoBehaviour
{
    [SerializeField] private Vector2 _direction;
	[SerializeField] private float _jumpPower;
    private Rigidbody2D rb;
	[SerializeField] private AudioSource _audio;

	public delegate void ObstaclesDelegate();
	public event ObstaclesDelegate overcomingObstacles;
	public event ObstaclesDelegate collisionWithAnObstacle;

	void Start()
    {
		_audio = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody2D>();
		_audio.volume = PlayerPrefs.GetFloat("SoundVolume");
	}
    public void Jump ()
    {
        rb.velocity = Vector2.up * _jumpPower;
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.tag == "Enemy")
        {
			collisionWithAnObstacle.Invoke();
		}
        else if (collision.tag == "Score")
        {
            overcomingObstacles?.Invoke();
        }
	}
    
}
