using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Clase1611
{ 
    public class Player : MonoBehaviour
    {
        // Classes
        [System.Serializable]
        public class StatusBar
        {
            // Variables
            [SerializeField] private FillableBar m_bar;
            [Space]
            [SerializeField] private float m_initialValue;
            [SerializeField] private float m_maxValue;

            private float m_actualValue;

            // Properties
            public float ActualValue
            {
                get => m_actualValue;
                set
                {
                    m_actualValue = Mathf.Clamp(value, 0, m_maxValue);
                    m_bar.SetFillValue(m_actualValue / m_maxValue);
                }
            }

            public float MaxValue => m_maxValue;

            // Constructor
            public StatusBar(float initial, float max)
            {
                m_initialValue = initial;
                m_maxValue = max;
            }

            // Methods
            /// <summary>
            /// Initialize system.
            /// </summary>
            public void Initialize()
            {
                m_actualValue = m_initialValue;
                m_bar.SetFillValue(m_actualValue / m_maxValue);
            }

            /// <summary>
            /// Reset the values.
            /// </summary>
            public void Reset() => Initialize();
        }

        // Variables
        [Header("Health")]
        [SerializeField] private StatusBar m_healthBar = new StatusBar(20, 20);
        [SerializeField] private KeyCode m_getDamageKey = KeyCode.D;
        [SerializeField] private int m_damage = 2;

        [Header("XP")]
        [SerializeField] private StatusBar m_xpBar = new StatusBar(4, 16);
        [SerializeField] private KeyCode m_getXPKey = KeyCode.X;
        [SerializeField] private int m_xp = 1;

        [Header("Mana")]
        [SerializeField] private StatusBar m_manaBar = new StatusBar(256, 256);
        [SerializeField] private KeyCode m_useManaKey = KeyCode.E;
        [SerializeField] private int m_manaUsage = 45;
        [SerializeField] private int m_manaRefill = 32;

        // Methods
        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        private void Start()
        {
            ResetFills();
        }

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        private void Update()
        {
            // Health
            if (Input.GetKeyDown(m_getDamageKey))
            {
                m_healthBar.ActualValue -= m_damage;
            }

            // XP
            if (Input.GetKeyDown(m_getXPKey))
            {
                m_xpBar.ActualValue += m_xp;
                if (m_xpBar.ActualValue == m_xpBar.MaxValue)
                {
                    m_xpBar.ActualValue = 0;
                }
            }

            // Mana
            m_manaBar.ActualValue += m_manaRefill * Time.deltaTime;

            if (Input.GetKeyDown(m_useManaKey))
            {
                m_manaBar.ActualValue -= m_manaUsage;
            }

            // Reset
            if (Input.GetKeyDown(KeyCode.R))
            {
                ResetFills();
            }
        }

        /// <summary>
        /// Reset all the fill bars.
        /// </summary>
        private void ResetFills()
        {
            m_healthBar.Initialize();
            m_xpBar.Initialize();
            m_manaBar.Initialize();
        }

    }
}
