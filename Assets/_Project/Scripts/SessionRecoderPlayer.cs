using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Google.XR.ARCoreExtensions;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace Render.Scripter.Session.Recorder
{
    public class SessionRecoderPlayer : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] private ARPlaybackManager _playbackManager;
        [SerializeField] private ARSession _session;
    
        private PlaybackStatus _lastStatus = PlaybackStatus.None;
        private string _filePath;
        void Start()
        {
            _filePath = Path.Combine(Application.persistentDataPath, "session.mp4");
            Debug.Log(_filePath);
            _session.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (_lastStatus != _playbackManager.PlaybackStatus)
            {
                Debug.Log(_playbackManager.PlaybackStatus);
            }

            _lastStatus = _playbackManager.PlaybackStatus;
        }

        public void Play()
        {
            Uri uri = new Uri(_filePath);
            _playbackManager.SetPlaybackDatasetUri(uri);

            _session.enabled = true;
        }
    }
    
}
