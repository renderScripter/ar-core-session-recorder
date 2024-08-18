using System.Collections;
using System.Collections.Generic;
using Google.XR.ARCoreExtensions;
using UnityEngine;

namespace Render.Scripter.Session.Recorder
{
    public class SessionRecorderController : MonoBehaviour
    {
        private ARCoreRecordingConfig _config;
        // Start is called before the first frame update
        void Start()
        {
            _config = ScriptableObject.CreateInstance<ARCoreRecordingConfig>();
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
    
}
