using Systems;
using UnityEngine;
using static Player.SuperAttackController;

namespace Player
{
    public class Beam : MonoBehaviour
    {
        public Transform gunPoint;
        private SpriteRenderer _blastRenderer;

        private float _charge; 
        private float _attackTime;
        [SerializeField] private float attackTimeMAX;

        private bool runCode = false;
        private void Awake()
        {
            VariableInitialize();
            BeamReset();
        }
        
        private void OnEnable()
        {
            runCode = true;
        }

        private void OnDisable()
        {
            BeamReset();
        }

        private void Update()
        {
            if (!runCode) return;
            RunSpecial();
        }

        public void RunSpecial()
        {
            BeamInitializer();
            BeamAttack();
            BeamController();
            
            gunPoint.transform.localScale = new Vector3(Mathf.PingPong(Time.time*10f, 1f)+0.5f, 1f, 1f);
        }

        private void BeamInitializer()
        {
            _blastRenderer.enabled = true;
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
                this.enabled = false;
            }
        }
        
        private void BeamController()
        {
            if (Camera.main is null) return;
            var screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
            
            var position = transform.position;

            var dir = new Vector3(position.x, screenBounds.y, 0f);
            var lineCastHit = Physics2D.Linecast(gunPoint.position, dir);
            
            var maxDistance = Vector3.Distance(new Vector3(position.x, screenBounds.y, 0f), position);
            _blastRenderer.size = new Vector2(0.4f, maxDistance);
            
            if (lineCastHit.collider == null) return;
                if (lineCastHit.collider.CompareTag("Enemy"))
                {
                    ObjectPooler.ReturnToPool(lineCastHit.collider.gameObject);
                }
                
            Debug.DrawLine(position, new Vector3(position.x, screenBounds.y, 0f));
        }
        
        private void BeamReset()
        {
            _blastRenderer.enabled = false;
            _attackTime = attackTimeMAX;
            runCode = false;
            SetAuto(true);
            canAttack = false;
        }

        private void VariableInitialize()
        {
            _blastRenderer = gunPoint.GetComponent<SpriteRenderer>();
        }
    }
}