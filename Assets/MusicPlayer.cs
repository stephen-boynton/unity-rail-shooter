using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {
    [SerializeField] int delaySeconds = 1;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadGame", delaySeconds);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LoadGame() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;
        SceneManager.LoadScene(nextScene);
    }
}
