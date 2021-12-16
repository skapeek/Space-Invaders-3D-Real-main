using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleplayerScreen : MonoBehaviour
{
    public Button nextButton;
    public GameObject canvas7;
    public GameObject canvas4;
    public AudioSource cancelsfx;

    private void OnEnable()
    {
        nextButton.Select();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            goBack();
        }
    }

    public void goBack()
    {
        cancelsfx.Play();
        canvas4.SetActive(true);
        canvas7.SetActive(false);
    }
}
