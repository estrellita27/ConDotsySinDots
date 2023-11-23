using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SML.Dots
{
    [BurstCompile]
    public struct FindNearestJob : IJob
    {
        [ReadOnly] public NativeArray<float3> AlienPositions;
        [ReadOnly] public NativeArray<float3> RomanoPositions;
        public NativeArray<float3> NearestAlienPositions;

        public void Execute()
        {
            for (int i = 0; i < RomanoPositions.Length; i++)
            {
                float3 romanoPos = RomanoPositions[i];
                float nearestDistSq = float.MaxValue;
                for (int j = 0; j < AlienPositions.Length; j++)
                {
                    float3 alienPos = AlienPositions[j];
                    float distSq = math.distancesq(romanoPos, alienPos);
                    if (distSq < nearestDistSq)
                    {
                        nearestDistSq = distSq;
                        NearestAlienPositions[i] = alienPos;
                    }
                }
            }
        }
    }
}
