using UnityEngine;

[RequireComponent(typeof(Creature))]
public class Attacker : MonoBehaviour
{
    public int strengh = 0;

    public void Hit(Creature target, float damage)
    {
        target.TakeDamage(damage);
    }
}
