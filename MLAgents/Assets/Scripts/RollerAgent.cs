using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Policies;


public class RollerAgent : Agent
{
    public Transform target;
    private Rigidbody rBody;


    public override void Initialize()
    {
        this.rBody = GetComponent<Rigidbody>();
    }
    
    
}
