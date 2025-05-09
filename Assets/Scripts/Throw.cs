using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject projectile, projectileSample1, projectileSample2, projectileSample3;
    public bool shoot = true;

    
    void Awake()
    {
        this.enabled = false; 
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && shoot == true)
        {
            shoot = false;
            projectile.transform.parent = null;
            projectile.GetComponent<Rigidbody>().isKinematic = false;
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            Invoke(nameof(CreateProjectile), 0.5f);
        }
    }
    public void CreateProjectile()
    {
        int x = Random.Range(1, 4);
        GameObject newProjectile = null;
        if(x == 1)        
            newProjectile = Instantiate(projectileSample1, transform);
        if (x == 2)
            newProjectile = Instantiate(projectileSample2, transform);
        if (x == 3)
            newProjectile = Instantiate(projectileSample3, transform);


        newProjectile.SetActive(true);
        projectile = newProjectile;
        shoot = true;
    }
}
