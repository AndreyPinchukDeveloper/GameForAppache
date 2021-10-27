using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class OpenCard : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    [SerializeField] private Sprite heros;

    public Image ObjectWithImage;
    public Sprite spriteToChange;
    private void Start()
    {
        ObjectWithImage.sprite = spriteToChange;
    }
    public void OnMouseDown()
    {
        if (cardBack.activeSelf)
        {
           cardBack.SetActive(false);
           StartCoroutine(Load());
        }
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
