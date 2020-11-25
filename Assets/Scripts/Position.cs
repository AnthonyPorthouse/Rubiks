using System.Collections.Generic;
using UnityEngine;

public class Position
{
    public Vector3 Source { get; }
    public List<Vector3> Targets { get; }
    public Vector3 Axis { get; }

    public Position(Vector3 source, Vector3 axis, List<Vector3> targets)
    {
        Source = source;
        Axis = axis;
        Targets = targets;
    }
}