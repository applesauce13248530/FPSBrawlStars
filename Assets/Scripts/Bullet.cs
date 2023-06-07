using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;

    public float speed = 70f;
    public static bool takeDamage = false;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            Destroy(gameObject);
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    public static void HitTarget()
    {
        takeDamage = true;
        Debug.Log("WE HIT SOMETHING");
        //Destroy(gameObject);
    }
}
