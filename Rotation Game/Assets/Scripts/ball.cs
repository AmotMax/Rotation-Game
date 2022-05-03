using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ball : MonoBehaviour
{
    public Transform spawn, spawnArrow, bin;
    public GameObject another, platform;
    public float timer, initialTime;
    public bool timerGo, soundCheck, newSpawn, isLittle, finish;
    public float size;
    public int number;

    public Rigidbody rb;
    public float nominalSpeed = 3f;
    public AudioSource aSource;
   

    public GameObject door;
    public GameObject doorSound, winSound, dieSound, growSound, shrinkSound;
    public GameObject doorParticle, winParticle, dieParticle, growParticle, shrinkParticle;



    // Start is called before the first frame update
    void Start()
    {
        Spawn();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerGo)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0 && !finish)
        {
            Spawn();
        }

        if (timer <= 0 && finish)
        {
            SceneManager.LoadScene(number);
        }

        if (soundCheck)
        {
            aSource.pitch = rb.velocity.magnitude / nominalSpeed;
        }
        else
        {
            aSource.pitch = 0;
        }

        if (isLittle)
        {
            nominalSpeed = 3;

        }
        if (!isLittle)
        {
            nominalSpeed = 6;

        }



    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Good"))
        {
            Debug.Log("posé");
            transform.position = bin.position;
            soundCheck = false;

            timerGo = true;
            finish = true;

            Instantiate(winParticle, other.transform.position, Quaternion.identity);
            Instantiate(winSound, other.transform.position, Quaternion.identity);
        } 

        if (other.CompareTag("Bad"))
        {
            Instantiate(dieParticle, transform.position, Quaternion.identity);
            
            transform.position = bin.position;
            timerGo = true;
            platform.GetComponent<Rotation>().canControl = false;
            soundCheck = false;

            
            Instantiate(dieSound, other.transform.position, Quaternion.identity);

        }


        if (other.CompareTag("Shrink"))
        {
            
            if (!isLittle)
            {
                Instantiate(shrinkParticle, other.transform.position, Quaternion.identity);
                Instantiate(shrinkSound, other.transform.position, Quaternion.identity);
            }

            transform.localScale = new Vector3 (size, size, size);
            isLittle = true;


           
        }

        if (other.CompareTag("Grow"))
        {
            if(isLittle)
            {
                Instantiate(growParticle, other.transform.position, Quaternion.identity);
                Instantiate(growSound, other.transform.position, Quaternion.identity);
            }
            
            transform.localScale = new Vector3(1, 1, 1);
            newSpawn = true;
            isLittle = false;

            
            

        }

        if (other.CompareTag("Key"))
        {
            Destroy(door.gameObject);
            Destroy(other.gameObject);

            Instantiate(doorParticle, door.transform.position, Quaternion.identity);
            Instantiate(doorParticle, other.transform.position, Quaternion.identity);
            Instantiate(doorSound, other.transform.position, Quaternion.identity);


        }
    }

    void Spawn()
    {
        if(!newSpawn)
        {
            transform.position = spawn.position;
        }

        if (newSpawn)
        {
            transform.position = spawnArrow.position;
        }

        transform.position = spawn.position;
        timerGo = false;
        timer = initialTime;
        platform.GetComponent<Rotation>().canControl = true;
        rb.velocity = new Vector3(0, 0, 0);
    }

    public void OnCollisionEnter(Collision collision)
    {
        soundCheck = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        soundCheck = false;
    }


}
