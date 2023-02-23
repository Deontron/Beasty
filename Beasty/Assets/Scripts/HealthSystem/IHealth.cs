using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DN.HealthSystem
{
    public interface IHealth
    {
        public float health { get; set; }

        public void GetHit(float damage, GameObject sender);
    }
}