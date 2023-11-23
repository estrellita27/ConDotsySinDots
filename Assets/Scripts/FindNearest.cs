using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace SML.Dots
{
    public class FindNearest : MonoBehaviour
    {
        NativeArray<float3> AlienPositions;
        NativeArray<float3> RomanoPositions;
        NativeArray<float3> NearestAlienPositions;

        public void Start()
        {
            Spawner spawner = Object.FindObjectOfType<Spawner>();
            AlienPositions = new NativeArray<float3>(spawner.NumAlien, Allocator.Persistent);
            RomanoPositions = new NativeArray<float3>(spawner.NumRomano, Allocator.Persistent);
            NearestAlienPositions = new NativeArray<float3>(spawner.NumRomano, Allocator.Persistent);
        }

        public void OnDestroy()
        {
            AlienPositions.Dispose();
            RomanoPositions.Dispose();
            NearestAlienPositions.Dispose();
        }

        public void Update()
        {
           
            for (int i = 0; i < AlienPositions.Length; i++)
            {
                AlienPositions[i] = Spawner.AlienTransforms[i].localPosition;
            }
            for (int i = 0; i < RomanoPositions.Length; i++)
            {
                RomanoPositions[i] = Spawner.RomanoTransforms[i].localPosition;
            }

            FindNearestJob findJob = new FindNearestJob
            {
                AlienPositions = AlienPositions,
                RomanoPositions = RomanoPositions,
                NearestAlienPositions = NearestAlienPositions,
            };

            JobHandle findHandle = findJob.Schedule();

            findHandle.Complete();

            for (int i = 0; i < RomanoPositions.Length; i++)
            {
                Debug.DrawLine(RomanoPositions[i], NearestAlienPositions[i]);
            }
        }
    }
}