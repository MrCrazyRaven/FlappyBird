using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    private int _difficulty;
	[SerializeField] private GameObject _settings;
	[SerializeField] private AudioSource _audio;
	[SerializeField] private float _soundVolume;

	private void Start()
	{
		_soundVolume = PlayerPrefs.GetFloat("SoundVolume");
	}
	private void Update()
	{
			_audio.volume = _soundVolume;
	}
	public void ExitSettings() 
    {
		PlayerPrefs.SetFloat("SoundVolume", _soundVolume);
		_audio.volume = PlayerPrefs.GetFloat("SoundVolume");
		_settings.SetActive(false);
		Debug.Log(PlayerPrefs.GetFloat("SoundVolume"));
        
    }
	
	public void DifficultySelection(int value)
    {
        switch (value)
        {
            case 0:
                _difficulty = 3;				
				break;

            case 1:
                _difficulty = 5;				
				break;

            case 2:
                _difficulty = 7;
				break;
				default: 
				_difficulty = 3;
				break;
			
        }
		PlayerPrefs.SetInt("difficulty", _difficulty);

	}
	public void SettingSound(float value)
	{
		_soundVolume = value;
	}



}
