using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{

    Soldier curTarget;
    Team myTeam;
    Vitals myVitals;

    Transform myTransform;

    Animator anim;

    [SerializeField] float minAttackDistance = 10, maxAttackDistance = 25, moveSpeed = 15;

    [SerializeField] float damageDealt = 50f;
    [SerializeField] float fireCooldown = 1f;
    float curFireCooldown = 0;


    public enum ai_states
    {
        idle,
        combat,
        move
    }
    public ai_states state = ai_states.idle;

 
    void Start()
    {
        myTransform = transform;
        myTeam = GetComponent<Team>();
        myVitals = GetComponent<Vitals>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (myVitals.getCurHealth() > 0)
        {
            switch (state)
            {
                case ai_states.idle:
                    stateIdle();
                    break;
                case ai_states.move:
                    stateMove();
                    break;
                case ai_states.combat:
                    stateCombat();
                    break;
                default:
                    break;
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    void stateIdle()
    {
        if (curTarget != null && curTarget.GetComponent<Vitals>().getCurHealth() > 0)
        {
            if (Vector3.Distance(myTransform.position, curTarget.transform.position) <= maxAttackDistance && Vector3.Distance(myTransform.position, curTarget.transform.position) >= minAttackDistance)
            {
                state = ai_states.combat;
            }
            else
            {
                anim.SetBool("move", true); 
                state = ai_states.move; 
            }
        }
        else
        {
            Soldier[] allSoldiers = GameObject.FindObjectsOfType<Soldier>();
            Soldier bestTarget = null;
            for(int i = 0; i <allSoldiers.Length; i++)
            {
                Soldier curSoldier = allSoldiers[i];
                if (curSoldier != this && curSoldier.GetComponent<Team>().getTeamNumber() != myTeam.getTeamNumber() && curSoldier.GetComponent<Vitals>().getCurHealth()>0)
                {
                    if (bestTarget == null)
                    {
                        bestTarget = curSoldier;
                    }
                    else
                    {
                        if(Vector3.Distance(curSoldier.transform.position, myTransform.position) > Vector3.Distance(bestTarget.transform.position, myTransform.position))
                        {
                            bestTarget = curSoldier;
                        }
                    }
                }
                
            }
            if(bestTarget != null)
            {
                curTarget = bestTarget;
            }
        }
    }

    void stateMove()
    {
        if (curTarget != null && curTarget.GetComponent<Vitals>().getCurHealth() > 0)
        {
            myTransform.LookAt(curTarget.transform); 
            if (Vector3.Distance(myTransform.position, curTarget.transform.position) > maxAttackDistance)
            {
                myTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            }else if(Vector3.Distance(myTransform.position, curTarget.transform.position) < maxAttackDistance)
            {
                myTransform.Translate(Vector3.forward * -1 * moveSpeed * Time.deltaTime);
            }
            else
            {
                anim.SetBool("move", false);
                state = ai_states.combat;

            }
        }
        else
        {
            anim.SetBool("move", true);
            state = ai_states.idle; 
        }
        
    }

    void stateCombat()
    {
        if (curTarget != null && curTarget.GetComponent<Vitals>().getCurHealth() > 0)
        {
            myTransform.LookAt(curTarget.transform);
            if (Vector3.Distance(myTransform.position, curTarget.transform.position) <= maxAttackDistance && Vector3.Distance(myTransform.position, curTarget.transform.position) >= minAttackDistance)

            {
                if (curFireCooldown <= 0)
                {
                    anim.SetTrigger("fire");
                    curTarget.GetComponent<Vitals>().getHit(damageDealt); 
                    curFireCooldown = fireCooldown; 
                }
                else
                {
                    curFireCooldown -= 1 * Time.deltaTime; 
                }
            }
            else
            {
                anim.SetBool("move", true);
                state = ai_states.move;
            }
        }
        else
        {
            state = ai_states.idle; 
        }
    }


    
}