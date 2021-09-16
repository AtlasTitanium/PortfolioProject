using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerManager : MonoBehaviour
{
    private void Update() {
        Debug.Log("is VR active: " + ExampleUtil.isPresent().ToString());
    }
}

internal static class ExampleUtil
{
    public static bool isPresent() {
        var xrDisplaySubsystems = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances<XRDisplaySubsystem>(xrDisplaySubsystems);
        foreach (var xrDisplay in xrDisplaySubsystems) {
            if (xrDisplay.running) {
                return true;
            }
        }
        return false;
    }
}
