using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Doozy.Runtime.Common.Extensions;
using Google.XR.ARCoreExtensions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

namespace Render.Scripter.Session.Recorder
{
    public class SessionRecorderController : Singleton<SessionRecorderController>
    {
        private ARCoreRecordingConfig _config;
        private string _filePath;
        private RecordingStatus _lastStatus = RecordingStatus.None;
        private Uri _recordingUri;
        private string _filename;

        [SerializeField]
        private ARRecordingManager _recordingManager;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        public void SetFileName(string filename)
        {
            _filename = filename.IsNullOrEmpty() ? "ar-session" : filename;
            _filename += ".mp4";
        }
        public void Setup()
        {
            _config = ScriptableObject.CreateInstance<ARCoreRecordingConfig>();
            _filePath = Path.Combine(Application.persistentDataPath, _filename);
            _recordingUri = new Uri(_filePath);
            _config.Mp4DatasetUri = _recordingUri;
        }
        
        public void StartRecording()
        {
            _recordingManager.StartRecording(_config);
        }

        public void StopRecording()
        {
            _recordingManager.StopRecording();
            Debug.Log("File saved at : " + _recordingUri);
        }
        
        // Update is called once per frame
        void Update()
        {
            if (_lastStatus != _recordingManager.RecordingStatus)
            {
                Debug.Log("Current Recording Status: " + _recordingManager.RecordingStatus);    
            }

            _lastStatus = _recordingManager.RecordingStatus;
        }

        public void MoveToPlayer()
        {
            SceneManager.LoadScene(1);
        }
    }

}
