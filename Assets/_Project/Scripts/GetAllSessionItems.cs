using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Render.Scripter.Session.Utils;
using UnityEngine;

namespace Render.Scripter.Session
{
    public class GetAllSessionItems : MonoBehaviour
    {
        [SerializeField] private GameObject _sessionItemPrefab;

        [SerializeField] private bool _test;
        // Start is called before the first frame update
        void Start()
        {
            Load();
            if (_test)
            {
                Test();
            }
        }

        private void Test()
        {
            var sessionItem = Instantiate(_sessionItemPrefab, transform, true);
        }

        public void Load()
        {   
            
            // Delete all the available one
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            
            string path = Application.persistentDataPath;
            string[] mp4Files = Directory.GetFiles(path, "*.mp4");
            
            foreach (var file in mp4Files)  
            {
                var info = new FileInfo(file);
                var sessionItem = Instantiate(_sessionItemPrefab, transform, false);
                if (!sessionItem.TryGetComponent<SessionItem>(out var sessionItemComponent)) continue;
                sessionItemComponent.SetTitle(info.Name);
                sessionItemComponent.SetInfo(info.LastWriteTime.ToShortTimeString());
            }
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }
}