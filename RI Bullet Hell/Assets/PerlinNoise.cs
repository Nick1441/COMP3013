using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerlinNoise : MonoBehaviour
{

    public static PerlinNoise instance = null;



    public int width = 256;
    public int height = 256;

    public float scale = 20;

    public float offestX = 100;
    public float offsetY = 100;

    public int perlinGridStepSizeX;
    public int perlinGridStepSizeY;


    public bool visualizeObjects = false;
    public GameObject[] Prefabs;
    public RawImage visulizationUI;
    private Texture2D noiseTexture;

    // Start is called before the first frame update
    void Start()
    {
        offestX = Random.Range(0, 99999);
        offsetY = Random.Range(0, 99999);
    }

    // Update is called once per frame
    void Update()
    {
        GenerateTexture();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void Generate()
    {
        GenerateTexture();
        if (visualizeObjects)
        {
            VisualizePrefabs();
        }

    }
    void GenerateTexture()
    {
        noiseTexture = new Texture2D(width, height);

        //generate noisemap
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                noiseTexture.SetPixel(x, y, CalculateColour(x, y));
            }
        }

        noiseTexture.Apply();
        visulizationUI.texture = noiseTexture;
    }

    Color CalculateColour(int x, int y)
    {
        float xCoord = (float)x / width * scale + offestX;
        float yCoord = (float)y / height * scale + offsetY;


        float sample = Mathf.PerlinNoise(xCoord, yCoord);

        return new Color(sample, sample, sample);
    }

    void VisualizePrefabs()
    {
        GameObject objectParent = new GameObject("ObjectParent");
        objectParent.transform.SetParent(this.transform);

        for (int x = 0; x < perlinGridStepSizeX; x++)
        {
            for (int y = 0; y < perlinGridStepSizeY; y++)
            {
                int ranSelect = Random.Range(0, Prefabs.Length);

                GameObject spawn = Instantiate(Prefabs[ranSelect], new Vector3(SampleStepped(x, y),y,SampleStepped(x, y)) + transform.position, transform.rotation);

                spawn.transform.SetParent(objectParent.transform);
            }
        }


    }

    public float SampleStepped(int x, int y)
    {
        int gridStepSizeX = width / perlinGridStepSizeX;
        int gridStepSizeY = height / perlinGridStepSizeY;

        float sampleFloat = noiseTexture.GetPixel((Mathf.FloorToInt(x * gridStepSizeX)), (Mathf.FloorToInt(y * gridStepSizeY))).grayscale;
        return sampleFloat;
    }



}
