using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        var btn = GetComponent <Button>();
        
        btn.onClick.AddListener(OnClick); //Observer pattern

        
        void OnClick()
        {
            var input = FindObjectOfType<TMP_InputField>();
            int SceneNumber = int.Parse(input.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene((SceneNumber));
        }
    }
}
