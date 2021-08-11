using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public enum PlayMode
    {
        Keyboard,
        UI,
    }
    
    [RequireComponent(typeof(Blast), typeof(Beam))]
    public class SuperAttackController : MonoBehaviour
    {
        public PlayMode mode;
        public static bool canAttack = false;

        public float beamCharge;
        public float blastCharge; 
        public float chargeAmount;
        
        private Beam _beam; private Blast _blast; private static AutoShoot _autoShoot;
        
        // Start is called before the first frame update
        private void Start()
        {
            _beam = GetComponent<Beam>(); _blast = GetComponent<Blast>(); _autoShoot = GetComponent<AutoShoot>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (canAttack) return;
            beamCharge += chargeAmount * Time.deltaTime;                           
            blastCharge += chargeAmount * Time.deltaTime;

            if (mode == PlayMode.Keyboard)
            {
                if (Keyboard.current.qKey.wasPressedThisFrame) 
                    FireBeam();
                
                if (Keyboard.current.eKey.wasPressedThisFrame) 
                    FireBlast();
            }
            else if (mode == PlayMode.UI)
            {
                // Nothing
            }
        }

        private void FireBeam()
        {
            
            if (beamCharge > 100)
            {   
                canAttack = true;  
                SetBeam(true);
                SetAuto(false);
                beamCharge = 0;
            }
        }

        private void FireBlast()
        {
              
            if (blastCharge > 100)
            {
                canAttack = true;
                SetBlast(true);
                SetAuto(false);
                blastCharge = 0;
            }
        }
                             
        private void ChargeOverTime(float charge)
        {
            charge += chargeAmount * Time.deltaTime;
        }

        public static void SetAuto(bool onOff)
        {
            _autoShoot.enabled = onOff;
        }
        private void SetBeam(bool onOff)   
        {                                       
            _beam.enabled = onOff;         
        }
        private void SetBlast(bool onOff)   
        {                                       
            _blast.enabled = onOff;         
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag($"Blast"))
            {
                
            }
            if (other.CompareTag($"Beam"))     
            {
                
            }                                   
        }
    }
}