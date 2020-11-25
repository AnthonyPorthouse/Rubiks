using System.Collections.Generic;
using UnityEngine;

public class Positions
{
    public static List<Position> positions = new List<Position>
        {
            // -x
            new Position(
                new Vector3(-3f, 0, 0),
                new Vector3(1f, 0, 0),
                new List<Vector3>
                {
                    new Vector3(-1f, -1, -1),
                    new Vector3(-1f, -1, 0),
                    new Vector3(-1f, -1, 1),
                    new Vector3(-1f, 0, -1),
                    new Vector3(-1f, 0, 0),
                    new Vector3(-1f, 0, 1),
                    new Vector3(-1f, 1, -1),
                    new Vector3(-1f, 1, 0),
                    new Vector3(-1f, 1, 1),
                }
            ),
            // +x
            new Position(
                new Vector3(3f, 0, 0),
                new Vector3(1f, 0, 0),
                new List<Vector3>
                {
                    new Vector3(1f, -1, -1),
                    new Vector3(1f, -1, 0),
                    new Vector3(1f, -1, 1),
                    new Vector3(1f, 0, -1),
                    new Vector3(1f, 0, 0),
                    new Vector3(1f, 0, 1),
                    new Vector3(1f, 1, -1),
                    new Vector3(1f, 1, 0),
                    new Vector3(1f, 1, 1),
                }
            ),

            // -y
            new Position(
                new Vector3(0, -3, 0),
                new Vector3(0, 1, 0),
                new List<Vector3>
                {
                    new Vector3(-1, -1, -1),
                    new Vector3(-1, -1, 0),
                    new Vector3(-1, -1, 1),
                    new Vector3(0, -1, -1),
                    new Vector3(0, -1, 0),
                    new Vector3(0, -1, 1),
                    new Vector3(1, -1, -1),
                    new Vector3(1, -1, 0),
                    new Vector3(1, -1, 1),
                }
            ),
            // +y
            new Position(
                new Vector3(0, 3, 0),
                new Vector3(0, 1, 0),
                new List<Vector3>
                {
                    new Vector3(-1, 1, -1),
                    new Vector3(-1, 1, 0),
                    new Vector3(-1, 1, 1),
                    new Vector3(0, 1, -1),
                    new Vector3(0, 1, 0),
                    new Vector3(0, 1, 1),
                    new Vector3(1, 1, -1),
                    new Vector3(1, 1, 0),
                    new Vector3(1, 1, 1),
                }
            ),

            // -z
            new Position(
                new Vector3(0, 0, -3),
                new Vector3(0, 0, 1),
                new List<Vector3>
                {
                    new Vector3(-1, -1, -1),
                    new Vector3(-1, 0, -1),
                    new Vector3(-1, 1, -1),
                    new Vector3(0, -1, -1),
                    new Vector3(0, 0, -1),
                    new Vector3(0, 1, -1),
                    new Vector3(1, -1, -1),
                    new Vector3(1, 0, -1),
                    new Vector3(1, 1, -1),
                }
            ),
            // +z
            new Position(
                new Vector3(0, 0, 3),
                new Vector3(0, 0, 1),
                new List<Vector3>
                {
                    new Vector3(-1, -1, 1),
                    new Vector3(-1, 0, 1),
                    new Vector3(-1, 1, 1),
                    new Vector3(0, -1, 1),
                    new Vector3(0, 0, 1),
                    new Vector3(0, 1, 1),
                    new Vector3(1, -1, 1),
                    new Vector3(1, 0, 1),
                    new Vector3(1, 1, 1),
                }
            ),
        };
}