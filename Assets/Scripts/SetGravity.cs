using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class SetGravity : MonoBehaviour
{
    public Vector3Control gravity { get; }

    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(GravitySensor.current); //Enables  // can be changed to Accelerometer instead of GravitySensor
        // InputSystem.DisableDevice(GravitySensor.current); // Disables
        if (GravitySensor.current.enabled)
        {
            Debug.Log("Gravity is enabled");
        }

        // Get sampling frequency of gravity.
        var frequency = GravitySensor.current.samplingFrequency;
        // Set sampling frequency of gravity to sample 16 times per second.
        GravitySensor.current.samplingFrequency = 30;

    }

    // Update is called once per frame
    void Update()
    {
        var gravity = GravitySensor.current.gravity.value;
        
        //flip Z axis, since flat down phone yields negative Z gravity
        gravity.z *= -1;
        //Sclale gravity, since sensor returns normalised gravity.
        gravity *= 9.81f;
        Physics.gravity = gravity;
    }
}