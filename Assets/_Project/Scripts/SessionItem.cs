using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;


namespace Render.Scripter.Session.Utils
{
    public class SessionItem : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;

        [SerializeField] private TMP_Text _info;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void SetTitle(string text)
        {
            _title.text = text;
        }
        
        public void SetInfo(string info)
        {
            _info.text = info;
        }
    }
}


