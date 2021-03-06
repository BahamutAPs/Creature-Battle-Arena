﻿using System.Collections;
using AttackManagement;
using UnityEngine;


namespace AttackAreas
{
    public class CenteredAttack : AttackAreaOfEffect
    {
        public override IEnumerator Attack(Vector2 direction, Transform[] exitPoints, AttackBase attackBase, Creature creature)
        {
            var spriteObject = attackBase.SpriteObject;
            var attack = Instantiate(spriteObject, exitPoints[6].position, Quaternion.identity);
            var damage = attack.GetComponentInChildren<DamageManager>();
            damage.SetAttack(attackBase);
            damage.SetAttacker(creature);

            yield return new WaitForSeconds(.25f); 
    
            Destroy(attack);
        }
    }
}