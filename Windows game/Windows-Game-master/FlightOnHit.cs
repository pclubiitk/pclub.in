/// <summary>
/// Flight on hit. this script will take damage to the plane. If got hit by an object that are Taged in the list.
/// </summary>
using UnityEngine;
using System.Collections;

public class FlightOnHit : MonoBehaviour {
	
	public string[] Tag = new string[1]{"Scene"};// All scene object tag.
	public string AirportTag = "Airport";// air port tag.
	public int Damage = 100;
	public AudioClip[] SoundOnHit;
	void Start(){
		
	}
	
    private void OnCollisionEnter(Collision collision)
    {
		bool hit = false;
		
		for(int i = 0;i<Tag.Length;i++){
			if(collision.gameObject.tag == Tag[i]){
				hit = true;
			}
			if(collision.gameObject.tag == AirportTag){
				hit = false;
			}
		}
		
        if (hit)
        {
			if(SoundOnHit.Length>0)
			AudioSource.PlayClipAtPoint(SoundOnHit[Random.Range(0,SoundOnHit.Length)],this.transform.position);

			DamagePackage dm = new DamagePackage();
			dm.Damage = Damage;
			dm.Owner = collision.gameObject;
			this.gameObject.SendMessage("ApplyDamage",dm,SendMessageOptions.DontRequireReceiver);
           
		}	
    }
}
