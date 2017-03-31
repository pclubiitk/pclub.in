using UnityEngine;
using System.Collections;

public class ExplosionObject : MonoBehaviour
{
    public Vector3 Force;
    public GameObject Prefab;
    public int Num;
    public int Scale = 20;
    public AudioClip[] Sounds;
    public float LifeTimeObject = 2;
	public bool RandomScale;
	
    private void Start()
    {

        if (Sounds.Length > 0)
        {
            AudioSource.PlayClipAtPoint(Sounds[Random.Range(0, Sounds.Length)], transform.position);
        }
        if (Prefab)
        {
			// Spawn Prefab x Num when start.
            for (int i = 0; i < Num; i++)
            {
                Vector3 pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 20), Random.Range(-10, 10))/10f;
                GameObject obj = (GameObject) Instantiate(Prefab, transform.position + pos, transform.rotation);
                Destroy(obj, LifeTimeObject);
				
                float scale = Scale;
				if(RandomScale){
					scale = Random.Range(1, Scale);
				}

                if (scale > 0)
                    obj.transform.localScale = new Vector3(scale, scale, scale);
                if (obj.GetComponent<Rigidbody>())
                {
					Vector3 force = new Vector3(Random.Range(-Force.x, Force.x), Random.Range(-Force.y, Force.y),Random.Range(-Force.z, Force.z));
                    obj.GetComponent<Rigidbody>().AddForce(force);
                }
            }
        }
    }

}
