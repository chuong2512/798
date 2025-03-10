﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{

    public GameObject SelectedPuzzle;
    int OIL = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<puzzleScript>().InRightPosition)
                {
                    SelectedPuzzle = hit.transform.gameObject;
                    SelectedPuzzle.GetComponent<puzzleScript>().Selected = true;
                    SelectedPuzzle.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
                
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            if (SelectedPuzzle != null)
            {
                SelectedPuzzle.GetComponent<puzzleScript>().Selected = false;
                SelectedPuzzle = null;
            }
        }


        if (SelectedPuzzle != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPuzzle.transform.position = new Vector3(MousePoint.x,MousePoint.y, 0);
        }
    }
}
