using System;
using Systems;
using UnityEngine;

namespace Player
{
    public class Beam : MonoBehaviour
    {
        public Transform gunPoint;
        public Sprite bulletGraphics;

        private Input _input;
        private CapsuleCollider2D _blastCollider;
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
            RayCastTest();
            RunSpecial();
        }

        private void RayCastTest()
        {
            if (Camera.main is null) return;
            var top = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
            
            var position = transform.position;
            var MaxDistance = Vector3.Distance(new Vector3(position.x, top.y, 0f), position);
            
            // Increase Distance from Position to Top.y over time)
            var dir = new Vector3(position.x, top.y, 0f);
            
            // print("Distance to other: " + MaxDistance);
            
            var hit = Physics2D.Raycast(position, Vector2.up, MaxDistance);
            var hot = Physics2D.Linecast(gunPoint.position, dir);
            
            _blastRenderer.size = new Vector2(0.4f, MaxDistance);
            
            if (hot.collider == null) return;

            print("I hit:" + hot.transform.name);
            if (hot.collider.CompareTag("Enemy"))
            {
                print("I hit:" + hot.collider.name);
                ObjectPooler.ReturnToPool(hot.collider.gameObject);
            }
            
            Debug.DrawLine(position, new Vector3(position.x, top.y, 0f));
        }
        private void RunSpecial()
        {
            BeamInitializer();
            BeamAttack();
            
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
            _blastCollider.enabled = false;
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
            _blastCollider.enabled = false;
            _blastRenderer.sprite = null;
            _canBlast = false;
            _attackTime = attackTimeMAX;
        }

        private void VariableInitialize()
        {
            _input = GetComponent<Input>();
            _blastCollider = gunPoint.GetComponent<CapsuleCollider2D>();
            _blastRenderer = gunPoint.GetComponent<SpriteRenderer>();
        }
    }
}