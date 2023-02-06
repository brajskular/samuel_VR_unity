using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    public GameObject xrOrigin;
    public GameObject desktopCharacter;

    // Start is called before the first frame update
    void Start()
    {
        var xrSettings = XRGeneralSettings.Instance;
        if(xrSettings == null) {
            Debug.Log("xrSettings is null, sam");
            return;
        }
        
        var xrManager = xrSettings.Manager;
        if(xrManager == null) {
            Debug.Log("xrManager is null, sam");
            return;
        }
        var xrLoader = xrManager.activeLoader;
        if(xrLoader == null) {
            Debug.Log("xrLoader is null, sam");
            xrOrigin.SetActive(false);
            desktopCharacter.SetActive(true);
            return;
        }

        Debug.Log("xrLoader is not null, sam");
        xrOrigin.SetActive(true);
        desktopCharacter.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
