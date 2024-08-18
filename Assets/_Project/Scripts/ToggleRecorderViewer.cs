using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Render.Scripter.Session.Utils
{

    public class ToggleRecorderViewer : MonoBehaviour
    {
        [SerializeField] private TMP_Text _label;
        // Start is called before the first frame update
        void Start()
        {
            _label.text = "Recorder";
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        
        public void OnToggleView(bool status)
        {
            _label.text = status ? "Recorder" : "Viewer";
        }
        
        
    }
}

