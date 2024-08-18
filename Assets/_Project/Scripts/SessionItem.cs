using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;


namespace Render.Scripter.Session.Utils
{
    public class SessionItem : MonoBehaviour
    {
        [SerializeField] private TMP_Text _labelContainer;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void SetLabel(string text)
        {
            _labelContainer.text = text;
        }
    }
}


