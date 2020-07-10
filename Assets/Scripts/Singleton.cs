using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static object m_lock = new object();

    protected static T m_singleton;
    public static T singleton
    {
        get
        {
            lock (m_lock)
            {
                if (m_singleton == null)
                {
                    m_singleton = FindObjectOfType<T>();

                    if (m_singleton == null)
                    {
                        GameObject newInstanceObject = new GameObject();
                        newInstanceObject.name = "Singleton[" + typeof(T).ToString() + "]";
                        m_singleton = newInstanceObject.AddComponent<T>();
                    }
                }
            }

            return m_singleton;
        }
    }

    protected virtual void Awake()
    {
        lock (m_lock)
        {
            if (m_singleton == null)
            {
                m_singleton = FindObjectOfType<T>();

                if (m_singleton == null)
                {
                    GameObject newInstance = new GameObject();
                    newInstance.name = "Singleton[" + typeof(T).ToString() + "]";
                    m_singleton = newInstance.AddComponent<T>();
                }
                if (m_singleton != this)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
