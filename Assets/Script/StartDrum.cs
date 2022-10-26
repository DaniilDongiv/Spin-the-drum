using UnityEngine;

public class StartDrum : MonoBehaviour
{
    [SerializeField]
    private HingeJoint _hingeJoint;

    public NewBehaviourScript _speed;
    public ReverseDrum _reverseDrum;

    public void StartDrumTwist()
    {
        var speed = _speed.speed = 50f;
        if (_reverseDrum.IsActiv)
        {
            speed = _speed.speed = -50f;
        }
        
        var hingeJointMotor = _hingeJoint.motor;
        hingeJointMotor.targetVelocity = _speed.speed;
        _hingeJoint.motor = hingeJointMotor;
    }
}
