using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class EntityMoveBaker : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeedMultiplier;
    public Vector3 destination;

    private class Baker : Baker<EntityMoveBaker>
    {
        public override void Bake(EntityMoveBaker authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            if (entity != null)
            {
                AddComponent(entity, new EntityMove {
                
                    moveSpeed = authoring.moveSpeed, 
                    moveSpeedMultiplier = authoring.moveSpeedMultiplier, 
                    destination = authoring.destination
                });
            }
        }
    }
}
