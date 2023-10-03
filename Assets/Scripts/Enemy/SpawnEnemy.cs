﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject Player;
    
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _newEnemyPrefabs;
    [SerializeField]
    private GameObject _wolf;
    
    [SerializeField]
    private GameObject _bossArea;
    [SerializeField]
    private GameObject _boss;
    [SerializeField]
    private GameObject _bossEarthWorm;
    [SerializeField]
    private float _timeSpawnBoss;
    [SerializeField]
    private float _timeSpawnBossWorm;

    public static bool bossIsApper = false;
    public static bool boss1Die = false;

    [SerializeField]
    private GameObject _levelSlider;
    [SerializeField]
    private GameObject _listGoldFish;
    [SerializeField]
    private GameObject _listGoldFishAround;
    [SerializeField]
    private GameObject _salmon;



    private float countBoss = 1;

    private bool _goldFishApaer = false;

    [SerializeField]
    private GameObject _uiBossApear;

    void Start()
    {
        _timeInterval = Time.time;
    }

    private GameObject instanceBossArea;

    void Update()
    {

        /*if (Timer._curentTime > 10 && _goldFishApaer == false)
        {
            StartCoroutine(SpawnGoldFishEnemy(_listGoldFish, 15, new Vector3(-25,0,25)));
        }*/

        if (((Timer._curentTime > 0 && Timer._curentTime < 90) || (Timer._curentTime > 120 && Timer._curentTime < 220)) && bossIsApper == false)
        {
            InstancetiateEnemy();
        }
        if (((Timer._curentTime > 30 && Timer._curentTime < 40) || (Timer._curentTime > 90 && Timer._curentTime < 100)
            || (Timer._curentTime > 150 && Timer._curentTime < 160) || (Timer._curentTime > 210 && Timer._curentTime < 220)
            || (Timer._curentTime > 270 && Timer._curentTime < 280) || (Timer._curentTime > 330 && Timer._curentTime < 340)
            || (Timer._curentTime > 390 && Timer._curentTime < 400) || (Timer._curentTime > 450 && Timer._curentTime < 460)
            || (Timer._curentTime > 510 && Timer._curentTime < 520) || (Timer._curentTime > 570 && Timer._curentTime < 580)
            || (Timer._curentTime > 630 && Timer._curentTime < 640) || (Timer._curentTime > 690 && Timer._curentTime < 700)
            ) && bossIsApper == false)
        {
            InstancetiateNewEnemy();
        }
        if (((Timer._curentTime > 90 && Timer._curentTime < 120) || (Timer._curentTime > 220 && Timer._curentTime < 300)) && bossIsApper == false)
        {
            InstancetiateWolfEnemy(0.65f);
        }
        if (Timer._curentTime > 220 && Timer._curentTime < 300 && bossIsApper == false)
        {
            InstancetiateWolfEnemy(0.55f);
        }

        if (countBoss == 1)
        {
            BossIntancetiate(_boss, _timeSpawnBoss);
        }
        if (Timer._curentTime > Timer._timeBossDie && boss1Die == true)
        {
            bossIsApper = false;
            boss1Die = false;
        }
        if (countBoss == 2)
        {
            BossIntancetiate(_bossEarthWorm, _timeSpawnBossWorm);
        }
        if (Timer._curentTime > 300 && Timer._curentTime < 600 && bossIsApper == false)
        {
            InstancetiateSalmon();
        }

        if (Timer._curentTime > 360 && _goldFishApaer == false)
        {
            StartCoroutine(SpawnGoldFishEnemy(_listGoldFishAround, 60, Vector3.zero));
        }

        if (bossIsApper)
        {
            DestroyAllEnemy();
            _levelSlider.SetActive(false);
        }
        else
        {
            Destroy(instanceBossArea);
            _levelSlider.SetActive(true);
        }

        DestroyByDistance();
    }

    private IEnumerator SpawnGoldFishEnemy(GameObject goldFish, float timeInterval,Vector3 pos)
    {
        while (true)
        {
            _goldFishApaer = true;
            IntanceGoldFish(goldFish, pos);
            yield return new WaitForSeconds(timeInterval);
            _goldFishApaer = false;
        }
    }

    public void DestroyAllEnemy()
    {
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.name == "SardineMob Variant(Clone)")
            {
                Destroy(obj);
            }
        }

        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(var en in enemy)
        {
            Destroy(en);
        }
    }

    public void IntanceGoldFish(GameObject goldFish, Vector3 pos)
    {
        GameObject goldFishLeft = Instantiate(goldFish, CameraRotate.center + pos, goldFish.transform.rotation);
        Destroy(goldFishLeft, 12f);
    }

    public void BossIntancetiate(GameObject boss, float timeSpawn)
    {
        if (!bossIsApper && Timer._curentTime > timeSpawn && boss1Die == false)
        {
            GameObject UIBoss = Instantiate(_uiBossApear, gameObject.transform.position, _uiBossApear.transform.rotation);
            Destroy(UIBoss, 1f);

            instanceBossArea = Instantiate(_bossArea, transform.position, Quaternion.identity);
            Instantiate(boss, transform.position + new Vector3(15,0,15), Quaternion.identity);

            countBoss++;
            bossIsApper = true;
        }
    }

    public void InstancetiateEnemy()
    {
        if (Time.time - _timeInterval > 0.8f)
        {
            Vector3 offset = Random.onUnitSphere;
            if ((offset.x > 0.6f || offset.x <-0.6f) && (offset.z > 0.6f||offset.z <-0.6f))
           {
                offset.y = 0;
                Vector3 newOffset = transform.position + offset * Random.Range(15.2f, 15.20001f);

                Instantiate(_enemyPrefabs, newOffset, _enemyPrefabs.transform.rotation);
                _timeInterval = Time.time;
            }
        }
    }

    public void InstancetiateSalmon()
    {
        if (Time.time - _timeInterval > 0.8f)
        {
            Vector3 offset = Random.onUnitSphere;
            if ((offset.x > 0.6f || offset.x <-0.6f) && (offset.z > 0.6f||offset.z <-0.6f))
           {
                offset.y = 0;
                Vector3 newOffset = transform.position + offset * Random.Range(15.2f, 15.20001f);

                Instantiate(_salmon, newOffset, _enemyPrefabs.transform.rotation);
                _timeInterval = Time.time;
            }
        }
    }

    public void InstancetiateNewEnemy()
    {
        if (Time.time - _timeInterval > 0.8f)
        {
            Vector3 offset = Random.onUnitSphere;
            if ((offset.x > 0.5f || offset.x < -0.5f) && (offset.z > 0.5f || offset.z < -0.5f))
            {
                offset.y = 0;
                Vector3 newOffset = transform.position + offset * Random.Range(15.2f, 15.20001f);

                Instantiate(_newEnemyPrefabs, newOffset, _enemyPrefabs.transform.rotation);
                _timeInterval = Time.time;
            }
        }
    }
    public void InstancetiateWolfEnemy(float timeSpawn)
    {
        if (Time.time - _timeInterval > timeSpawn)
        {
            Vector3 offset = Random.onUnitSphere;
            if ((offset.x > 0.6f || offset.x < -0.6f) && (offset.z > 0.6f || offset.z < -0.6f))
            {
                offset.y = 0;
                Vector3 newOffset = transform.position + offset * Random.Range(15.2f, 15.20001f);

                Instantiate(_wolf, newOffset, _enemyPrefabs.transform.rotation);
                _timeInterval = Time.time;
            }
        }
    }

    public void DestroyByDistance()
    {
        GameObject destroyEnemy = GameObject.FindGameObjectWithTag("Enemy"); 
        GameObject destroyEnemyDef = GameObject.Find("SardineMob Variant(Clone)");
        GameObject coin = GameObject.FindGameObjectWithTag("Coin");
        GameObject bomb = GameObject.FindGameObjectWithTag("Bomb");
        GameObject magnet = GameObject.FindGameObjectWithTag("Magnet");
        GameObject heal = GameObject.FindGameObjectWithTag("Heal");
        GameObject experience = GameObject.FindGameObjectWithTag("Experience");
        GameObject root = GameObject.FindGameObjectWithTag("Root");

        float distance;
        if(destroyEnemy != null)
        {
            distance = Vector3.Distance(destroyEnemy.transform.position, gameObject.transform.position);
            if (distance > 45)
            {
                Destroy(destroyEnemy);
            }
        }

        float distanceDef;
        if(destroyEnemyDef != null)
        {
            distanceDef = Vector3.Distance(destroyEnemyDef.transform.position, gameObject.transform.position);
            if (distanceDef > 45)
            {
                Destroy(destroyEnemyDef);
            }
        }

        float distanceCoin;
        if (coin != null)
        {
            distanceCoin = Vector3.Distance(coin.transform.position, gameObject.transform.position);
            if (distanceCoin > 60)
            {
                Destroy(coin);
            }
        }

        float distanceBomb;
        if (bomb != null)
        {
            distanceBomb = Vector3.Distance(bomb.transform.position, gameObject.transform.position);
            if (distanceBomb > 60)
            {
                Destroy(bomb);
            }
        }

        float distanceMagnet;
        if (magnet != null)
        {
            distanceMagnet = Vector3.Distance(magnet.transform.position, gameObject.transform.position);
            if (distanceMagnet > 60)
            {
                Destroy(magnet);
            }
        }
        float distanceHeal;
        if (heal != null)
        {
            distanceHeal = Vector3.Distance(heal.transform.position, gameObject.transform.position);
            if (distanceHeal > 60)
            {
                Destroy(heal);
            }
        }
        
        float distanceExperience;
        if (experience != null)
        {
            distanceExperience = Vector3.Distance(experience.transform.position, gameObject.transform.position);
            if (distanceExperience > 60)
            {
                Destroy(experience);
            }
        }
        
        float distanceRoot;
        if (root != null)
        {
            distanceRoot = Vector3.Distance(root.transform.position, gameObject.transform.position);
            if (distanceRoot > 60)
            {
                Destroy(root);
            }
        }
    }
}
