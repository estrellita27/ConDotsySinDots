using UnityEngine;


namespace SML.Dots
{
    public class Spawner : MonoBehaviour
    {
        public static Transform[] AlienTransforms;

        public static Transform[] RomanoTransforms;

        public GameObject RomanoPrefab;
        public GameObject AlienPrefab;
        public int NumRomano;
        public int NumAlien;
        public float entityLifeTimeInMiliseconds;
        public Vector2 Bounds;
        

        public void Start()
        {
            Random.InitState(123);

            RomanoTransforms = new Transform[NumRomano];
            for (int i = 0; i < NumRomano; i++)
            {
                GameObject go = GameObject.Instantiate(RomanoPrefab);
                Romano romano = go.GetComponent<Romano>();
                Vector2 dir = Random.insideUnitCircle;
                romano.Direction = new Vector3(dir.x, 0, dir.y);
                RomanoTransforms[i] = go.transform;
                go.transform.localPosition = new Vector3(
                    Random.Range(0, Bounds.x), 0, Random.Range(0, Bounds.y));
            }

            AlienTransforms = new Transform[NumAlien];
            for (int i = 0; i < NumAlien; i++)
            {
                GameObject go = GameObject.Instantiate(AlienPrefab) ;
                Alien alien = go.GetComponent<Alien>();
                Vector2 dir = Random.insideUnitCircle;
                alien.Direction = new Vector3(dir.x, 0, dir.y);
                AlienTransforms[i] = go.transform;
                go.transform.localPosition = new Vector3(
                    Random.Range(0, Bounds.x), 0, Random.Range(0, Bounds.y));
            }
        }
    }
}