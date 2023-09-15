using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static int defaultBulletDamage = 10;
    public static int tankBulletDamage = 10;
    public static int flameDamage = 4;
    public static int airPlaneDamage = 5;
    public static int lightingDamage = 5;
    public static int turretBulletDamage = 3;


    public static float increaseAirPlaneDamage;




    public static int DeafaultDamage()
    {
        return defaultBulletDamage;
    }
    public static int TurretBulletDamage()
    {
        return turretBulletDamage;
    }
    public static int TankBulletDamage()
    {
        return tankBulletDamage;
    }
    public static int FlameDamage()
    {
        return flameDamage;
    }
    public static float AirPlaneDamage()
    {
        return airPlaneDamage;
    }
    public static int LightingDamage()
    {
        return lightingDamage;
    }
}
