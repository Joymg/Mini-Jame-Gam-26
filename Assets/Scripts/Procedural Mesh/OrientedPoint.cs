﻿
using UnityEngine;

namespace Procedural_Mesh
{
    [System.Serializable]
    public struct OrientedPoint
    {
        public Vector3 Position;
        public Quaternion Rotation;

        public OrientedPoint(Vector3 position, Quaternion rotation)
        {
            Position = position;
            Rotation = rotation;
        }
        
        public OrientedPoint(Vector3 position, Vector3 forward)
        {
            Position = position;
            Rotation = Quaternion.LookRotation(forward);
        }

        public Vector3 LocalToWorld(Vector3 localSpacePosition)
        {
            return Position + Rotation * localSpacePosition;
        }
        
    }
}