using UnityEngine;

public class Collectable : Collisions
{
    protected bool collected;
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            collected = true;
        }
    }

}
