using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
	[SerializeField] private int _score;
    public Bird _bird;
	[SerializeField] private GameObject _menu;
	[SerializeField] private GameObject _settings;

	// Start is called before the first frame update
	void Start()
    {
		_bird.collisionWithAnObstacle += defeat;
		_bird.overcomingObstacles += IncreaseScore;
	}
    private void IncreaseScore() 
    {
        _score++;
        _scoreText.text = _score.ToString();
	}
	private void defeat()
	{
		_menu.SetActive(true);
		Time.timeScale = 0;

	}
	public void RestartLevel()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("SampleScene");
		_menu.SetActive(false);
	}
	public void Settings()
	{
		_settings.SetActive(true);
	}
}
