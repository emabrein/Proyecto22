using System.Collections;
using UnityEngine;

public class PenduloEma : MonoBehaviour
{
#region Public Variables
public Rigidbody2D body2d;
public float leftPushRange;
public float rightPushRange;
public float velocityThreshold;
#endregion //Public Variables

  #region Private Variables

  #endregion // Private Variables  

  // (Unity Named Methods) 
  #region Main Methods
    
    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
        body2d.angularVelocity = velocityThreshold;
    }

    
    void Update()
    {
        Push();
    }
    #endregion //Main Methods

    #region Utility Methods
    public void Push()
    {
        if (transform.rotation.z > 0 
        && transform.rotation.z < rightPushRange
        && (body2d.angularVelocity > 0)
        && body2d.angularVelocity < velocityThreshold)
        {
            body2d.angularVelocity = velocityThreshold;
        }
        else if (transform.rotation.z < 0
        && transform.rotation.z > leftPushRange
        && (body2d.angularVelocity < 0)
        && body2d.angularVelocity > velocityThreshold * -1)
        {
            body2d.angularVelocity = velocityThreshold * -1;
        }
    }
    #endregion // Utility Methods
    
}
