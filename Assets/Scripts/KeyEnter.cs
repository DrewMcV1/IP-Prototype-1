using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeyEnter : MonoBehaviour
{

    public string key;
    Button button;
    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetButtonDown(key))
        {
            button.onClick.Invoke();
        }
    }
}