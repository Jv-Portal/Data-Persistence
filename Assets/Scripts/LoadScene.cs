
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LoadScene : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
