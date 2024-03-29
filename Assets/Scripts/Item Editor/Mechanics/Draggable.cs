﻿using System;
using UnityEngine;


public class Draggable : MonoBehaviour
{
    private Vector3 _startPosition;
    private void Start()
    {
        _startPosition = transform.position;
    }
    private void OnMouseDrag()
    {
        Vector3 position = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.WorldToScreenPoint(transform.position).z);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
        transform.position = new Vector3(worldPosition.x,worldPosition.y,worldPosition.z);
    }
    private void OnMouseUp()
    {
        EndMoving();
    }
    public void EndMoving()
    {
        transform.position = _startPosition;
    }
}