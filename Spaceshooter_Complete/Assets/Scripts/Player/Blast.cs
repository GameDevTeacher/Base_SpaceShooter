using UnityEngine;
using static Player.SuperAttackController;

namespace Player
{
    public sealed class Blast : MonoBehaviour
    {
        public Transform gunPoint;
        private SpriteRenderer _blastRenderer;

        private CircleCollider2D _blastCollider;
        [SerializeField] private float maxRadius = 20;
        [SerializeField] private float expansionRate = 0.05f;
        private Vector3 _transform;

        private bool runCode;

        private void Awake()
        {
            VariableInitialize();
            BlastReset();
        }

        private void OnEnable()
        {
            runCode = true;
        }

        private void OnDisable()
        {
            BlastReset();
        }

        private void Update()
        {
            if (!runCode) return;
            RunSpecial();
        }

        public void RunSpecial()
        {
            BlastInitializer();
            BlastAttack();
            gunPoint.transform.localScale = _transform;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("EnemyProjectile"))
            {
                Destroy(other.gameObject);
            }
        }
        
        private void BlastInitializer()
        {
            _blastCollider.enabled = true;
            _blastRenderer.enabled = true;
        }

        private void BlastAttack()
        {
            if (_transform.x < maxRadius)
            {
                _transform.x += expansionRate;
                _transform.y += expansionRate;
            }
            else
            {
                BlastReset();
                this.enabled = false;
            }
        }
        
        private void BlastReset()
        {
            _blastCollider.enabled = false;
            _blastRenderer.enabled = false;
            _transform = new Vector3(1f, 1f, 1f);
            runCode = false;
            SetAuto(true);
            canAttack = false;
        }

        private void VariableInitialize()
        {
            _blastCollider = gunPoint.GetComponent<CircleCollider2D>();
            _blastRenderer = gunPoint.GetComponent<SpriteRenderer>();
        }
    }
}