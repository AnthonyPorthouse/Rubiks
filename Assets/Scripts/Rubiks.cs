﻿using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Rubiks : MonoBehaviour
{
    [SerializeField]
    private float turnsPerSecond = 1;

    [SerializeField]
    private bool autoRotate = true;
    
    private Random _rand;
    private Position _currentPosition;

    private readonly List<GameObject> _selectedCubes = new List<GameObject>();
    private bool _isRotating;
    private float _rotateDirection;
    private int _turnCount;
    private float _currentRotation;

    // Start is called before the first frame update
    private void Start()
    {
        _rand = new Random();
    }

    private void FixedUpdate()
    {
        // If we're not rotating and autorotate is on, calculate which cubes we're rotating
        if (!_isRotating && autoRotate)
        {
            SelectRandomSide();
        }
        
        if(_isRotating)
        {
            RotateCubes();
        }
    }

    private void RotateCubes()
    {
        var nextAmount = Mathf.Min(90 * turnsPerSecond * Time.deltaTime, 90 - _currentRotation);
        _currentRotation += nextAmount;

        _selectedCubes.ForEach(cube =>
        {
            cube.transform.RotateAround(_currentPosition.Axis, _currentPosition.Axis, nextAmount * _rotateDirection);
        });

        if (_currentRotation >= 90f)
        {
            _isRotating = false;
        }
    }

    private void SelectRandomSide()
    {
        // Clear out our old selection of cubes
        _selectedCubes.Clear();

        // Get cubes to rotate
        RaycastHit hit;
        int item = _rand.Next(Positions.positions.Count);
        var nextPosition = Positions.positions[item];

        do
        {
            item = _rand.Next(Positions.positions.Count);
            nextPosition = Positions.positions[item];
        } while (_turnCount == 3 && nextPosition.Equals(_currentPosition));

        var source = nextPosition.Source;

        // Raycast at each cube in the currently selected side to determine which cubes are being rotated
        nextPosition.Targets.ForEach(target =>
        {
            var direction = target - source;

            Debug.DrawRay(source, direction, Color.yellow, 1f);

            if (Physics.Raycast(source, direction, out hit))
            {
                _selectedCubes.Add(hit.collider.gameObject);
            }
        });

        if (_selectedCubes.Count == 9)
        {
            // If the next rotation point is the same as the current, don't change turn direction
            if (_currentPosition == null || !nextPosition.Source.Equals(_currentPosition.Source))
            {
                _rotateDirection = _rand.Next(0, 2) == 0 ? -1f : 1f;
                _currentPosition = nextPosition;
                _turnCount = 0;
            }

            _isRotating = true;
            _currentRotation = 0;
            _turnCount++;
        }
    }
}