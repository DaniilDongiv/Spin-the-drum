using UnityEngine;

public class ReverseDrum : MonoBehaviour
{
    [SerializeField]
    private HingeJoint _hingeJoint;
    
    public NewBehaviourScript _speed;
    public bool IsActiv;
    
    public void ReverseDrumTwist()
    {
        var speed = _speed.speed *= -1f;
        var hingeJointMotor = _hingeJoint.motor;
        hingeJointMotor.targetVelocity = speed;
        _hingeJoint.motor = hingeJointMotor;
        if (IsActiv)
        {
            IsActiv = !IsActiv;
        }
        else
        {
            IsActiv = true;
        }
    }
}
