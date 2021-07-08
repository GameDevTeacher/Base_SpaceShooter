using Systems;
using UnityEngine;

namespace Player
{
    public class Beam : MonoBehaviour
    {
        public Transform gunPoint;
        public Sprite bulletGraphics;

        private Input _input;
        private SpriteRenderer _blastRenderer;

        private float _attackTime;
        [SerializeField] private float attackTimeMAX;

        private Vector3 _transform;
        private bool _canBlast;

        [SerializeField] private AnimationCurve _curve;
        
        private void Start()
        {
            VariableInitialize();
            BeamReset();
        }

        private void Update()
        {
            if (_input.Shoot && !_canBlast)
            {
                _canBlast = true;
            }
            
            if (!_canBlast) return;
            RunSpecial();
        }

        private void BeamController()
        {
            if (Camera.main is null) return;
            var screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
            
            var position = transform.position;
            var maxDistance = Vector3.Distance(new Vector3(position.x, screenBounds.y, 0f), position);
            
            // Increase Distance from Position to Top.y over time)
            var dir = new Vector3(position.x, screenBounds.y, 0f);
            var lineCastHit = Physics2D.Linecast(gunPoint.position, dir);
            
            _blastRenderer.size = new Vector2(0.4f, maxDistance);
            
            if (lineCastHit.collider == null) return;
            
                if (lineCastHit.collider.CompareTag("Enemy"))
                {
                    ObjectPooler.ReturnToPool(lineCastHit.collider.gameObject);
                }
                
                Debug.DrawLine(position, new Vector3(position.x, screenBounds.y, 0f));
        }
        private void RunSpecial()
        {
            BeamInitializer();
            BeamAttack();
            BeamController();
            
            gunPoint.transform.localScale = new Vector3(Mathf.PingPong(Time.time*10f, 1f)+0.5f, 1f, 1f);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                ObjectPooler.ReturnToPool(other.gameObject);
            }
        }
        
        private void BeamInitializer()
        {
            _blastRenderer.sprite = bulletGraphics;
        }

        private void BeamAttack()
        {
            if (_attackTime > 0)
            {
                _attackTime -= 1 * Time.deltaTime;
            }
            else
            {
                BeamReset();
            }
        }
        
        private void BeamReset()
        {
            _blastRenderer.sprite = null;
            _canBlast = false;
            _attackTime = attackTimeMAX;
        }

        private void VariableInitialize()
        {
            _input = GetComponent<Input>();
            _blastRenderer = gunPoint.GetComponent<SpriteRenderer>();
        }
    }
}