using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.EnvironmentInteractables
{
    public class Key : MonoBehaviour
    {
        #region Declarations --------------------------------------------------

        private LevelManager _levelManager;

        #endregion


        #region Private/Protected Methods -------------------------------------

        private void Start()
        {
            _levelManager = FindObjectOfType<LevelManager>();
        }

        private void Update()
        {
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _levelManager.AddKey(1);

                if (_levelManager.isSoundEnabled)
                    _levelManager.PlayPickupSound();

                Destroy(gameObject);
            }
        }

        #endregion
    }
}