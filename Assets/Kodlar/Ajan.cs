using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;


public class Ajan : Agent
{

    private Rigidbody RB3D;
    public Transform hedef;
    public float carpan = 5f;

    void Start()
    {
        RB3D = GetComponent<Rigidbody>();
    }

    public override void OnEpisodeBegin()
    {
        if (transform.localPosition.y < 0)
        {
            RB3D.angularVelocity = Vector3.zero;
            RB3D.velocity = Vector3.zero;
            transform.localPosition = new Vector3(0, 0.5f, 0);
        }
        //hedef.localPosition = new Vector3(Random.value * 8.5f - 4, 0.5f, Random.value * 8.5f - 4);
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(hedef.localPosition);
        sensor.AddObservation(transform.position);
        sensor.AddObservation(RB3D.velocity.x);
        sensor.AddObservation(RB3D.velocity.z);
    }
    public override void OnActionReceived(ActionBuffers actions)
    {
        Vector3 kontrolsinyali = Vector3.zero;
        kontrolsinyali.x = actions.ContinuousActions[0];
        kontrolsinyali.z = actions.ContinuousActions[1];
        RB3D.AddForce(kontrolsinyali * carpan);

        float hdefeolanfark = Vector3.Distance(transform.localPosition, hedef.localPosition);
        if (hdefeolanfark < 1.5f)
        {
            SetReward(1.0f);
            EndEpisode();
        }
        if (transform.localPosition.y < 0)
        {
            SetReward(-1f);
            EndEpisode();
        }
    }
    public override void Heuristic(in ActionBuffers antionsOut)
    {
        var contuniousActionsOut = antionsOut.ContinuousActions;
        contuniousActionsOut[0] = Input.GetAxis("Horizontal");
        contuniousActionsOut[1] = Input.GetAxis("Vertical");
    }
}
