using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
	[SerializeField] private float _speed;
	private void Start()
	{
		if (PlayerPrefs.HasKey("difficulty"))
		{
			_speed = PlayerPrefs.GetInt("difficulty");
		}
		else
		{
			_speed = 3.0f;
		}

		Debug.Log(_speed);
	}
	void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0);
        Destroy(gameObject, 10);
    }
	
}
