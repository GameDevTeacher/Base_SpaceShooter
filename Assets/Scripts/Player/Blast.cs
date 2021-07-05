using UnityEngine;

namespace Player
{
    public class Blast : MonoBehaviour
    {
        public Transform gunPoint;
        public Sprite bulletGraphics;

        private Input _input;
        private CircleCollider2D _blastCollider;
        private SpriteRenderer _blastRenderer;

        [SerializeField] private float MAXRadius = 10;
        [SerializeField] private float _expansionRate = 0.05f;

        [SerializeField] private Vector3 _transform;

        private bool canBlast;
        private void Start()
        {
            VariableInitialize();
            BlastReset();
        }

        private void Update()
        {
            if (_input.Shoot && !canBlast)
            {
                canBlast = true;
            }
            
            if (!canBlast) return;
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
            _blastRenderer.sprite = bulletGraphics;
        }

        private void BlastAttack()
        {
            if (_transform.x < MAXRadius)
            {
                _transform.x += _expansionRate;
                _transform.y += _expansionRate;
            }
            else
            {
                BlastReset();
            }
        }
        
        private void BlastReset()
        {
            _blastCollider.enabled = false;
            _blastRenderer.sprite = null;
            _transform = new Vector3(1f, 1f, 1f);
            canBlast = false;
        }


        private void VariableInitialize()
        {
            _input = GetComponent<Input>();
            _blastCollider = gunPoint.GetComponent<CircleCollider2D>();
            _blastRenderer = gunPoint.GetComponent<SpriteRenderer>();
        }
    }
}