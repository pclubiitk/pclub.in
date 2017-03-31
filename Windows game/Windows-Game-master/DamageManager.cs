/// <summary>
/// Damage manager. 
/// </summary>
using UnityEngine;
using System.Collections;

public class DamageManager : MonoBehaviour
{
    public AudioClip[] HitSound;
    public GameObject Effect;
    public int HP = 100;
	private int HPmax;
	public ParticleSystem OnFireParticle;
	
    private void Start()
    {
		HPmax = HP;
		if(OnFireParticle){
			OnFireParticle.Stop();
		}
    }
	// Damage function
    public void ApplyDamage(DamagePackage dm)
    {
		if(HP<0)
		return;
	
        if (HitSound.Length > 0)
        {
            AudioSource.PlayClipAtPoint(HitSound[Random.Range(0, HitSound.Length)], transform.position);
        }
        HP -= dm.Damage;
		if(OnFireParticle){
			if(HP < (int)(HPmax/2.0f)){
				OnFireParticle.Play();
			}
		}
        if (HP <= 0)
        {
			this.gameObject.SendMessage("OnDead",dm.Owner,SendMessageOptions.DontRequireReceiver);
            Dead();
        }
    }

    private void Dead()
    {
        if (Effect){
            GameObject obj = (GameObject)GameObject.Instantiate(Effect, transform.position, transform.rotation);
			if(this.GetComponent<Rigidbody>()){
				if(obj.GetComponent<Rigidbody>()){
					obj.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity;
					obj.GetComponent<Rigidbody>().AddTorque(Random.rotation.eulerAngles * Random.Range(100,2000));
				}
			}
		}
		
		
        Destroy(this.gameObject);
    }

}
