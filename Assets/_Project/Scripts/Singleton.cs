using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Render.Scripter.Session
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        // Property to access the Singleton instance
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Find the Singleton instance in the scene
                    _instance = FindObjectOfType<T>();

                    if (_instance == null)
                    {
                        // If no instance is found, create a new GameObject with the Singleton
                        GameObject singletonObject = new GameObject(typeof(T).Name);
                        _instance = singletonObject.AddComponent<T>();
                        DontDestroyOnLoad(singletonObject);
                    }
                }

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else if (_instance != this)
            {
                // Destroy duplicate instances
                Destroy(gameObject);
            }
        }
    }

}

