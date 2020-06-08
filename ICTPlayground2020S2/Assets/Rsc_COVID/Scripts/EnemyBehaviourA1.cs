using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourA1 : MonoBehaviour
{
    public Enums.Directions orientationSide = Enums.Directions.Up;
    public bool EnableFaceToTarget;
    public GameObject target;
    public UnitData unitData;
    public float minAggroDistance = 10.0f;
    public bool EnableAggroByDistance;
    public Vector3 start;
    public Rigidbody2D rigidbody2d;

    public ShootObjectMultiple weaponProjectileSystem;
    public Collider2D collider2d;

    // Start is called before the first frame update
    void Start()
    {
        

        if (!rigidbody2d)
        {
            rigidbody2d = GetComponent<Rigidbody2D>();
        }
        if (!collider2d)
        {
            collider2d = GetComponent<Collider2D>();
        }

        SetupUnitData();


    }

    void AdjustRotationToTarget()
    {
        if (EnableFaceToTarget)
        {//look towards the target, Playground utilities
            Utils.SetAxisTowards(
            orientationSide,
            transform,
            target.transform.position - transform.position);
        }
    }

    private void OnDrawGizmosSelected()
    { // Aggro Distance
        if (EnableAggroByDistance)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, minAggroDistance);
        }
    }

    void ShootWeapon()
    {
        if (weaponProjectileSystem)
        {
            weaponProjectileSystem.ShootObject();
        }
    }


    public void DetectEnemy()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }


    void FollowTarget()
    {
        // Follow Target
        transform.position = Vector2.MoveTowards(transform.position,target.transform.position,unitData.speed * Time.deltaTime);

    }

    bool IsTargetInAggroRange(Transform theTarget)
    {
        return Vector2.Distance(
        transform.position,
        theTarget.position
        ) <= minAggroDistance;
    }


    public void SetupUnitData()
    {
        // Reference Playground HealthSystemAttribute component
        HealthSystemAttribute healthSystem
        = GetComponent<HealthSystemAttribute>();
        if (healthSystem)
        {
            healthSystem.maxHealth = (int)unitData.maxHealth;
            healthSystem.health = (int)unitData.health;
        }

        ModifyHealthAttribute modifyHealthAttrb =
            GetComponent<ModifyHealthAttribute>();
        if (modifyHealthAttrb)
        {
            modifyHealthAttrb.healthChange =
            (int)-unitData.collisionDamage;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (!target)
        {
            DetectEnemy();
        }
        else
        {
            if (EnableAggroByDistance)
            {
                if (IsTargetInAggroRange(target.transform))
                {
                    FollowTarget();
                    AdjustRotationToTarget();
                }
            }
            else
            {
                FollowTarget();
                AdjustRotationToTarget();
                


            }
        }

    }
}
