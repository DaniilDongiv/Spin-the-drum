using UnityEngine;

public class StopDrum : MonoBehaviour
{
    [SerializeField]
    private HingeJoint _hingeJoint;
    public NewBehaviourScript _speed;

    public void StopDrumTwist()
    {
        var speed = _speed.speed = 0f;
        var hingeJointMotor = _hingeJoint.motor;
        hingeJointMotor.targetVelocity = speed;
        _hingeJoint.motor = hingeJointMotor;
    }
}
