using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleSelect : MonoBehaviour
{
    public GameObject StartPanel;
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 60; i++)
        {
            GameObject.Find("puzzle (" + i + ")").transform.Find("Piece").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
    }


     
}
