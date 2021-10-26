using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
        }
       
    }
}
