using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveConfigSO", menuName = "~/Library/CloudStorage/OneDrive-SUNYMorrisville/CITA 212/Laser Defender/Assets/Scripts/WaveConfigSO.cs/WaveConfigSO", order = 0)]
public class WaveConfigSO : ScriptableObject 
{
   [SerializeField] Transform pathPrefab;
   [SerializeField] float moveSpeed = 5f;

   public Transform GetStartingWaypoint()
   {
       return pathPrefab.GetChild(0);
   }

   public List<Transform> GetWaypoints()
   {
       List<Transform> waypoints = new List<Transform>();
       foreach(Transform child in pathPrefab)
       {
           waypoints.Add(child);
       }
       return waypoints;
   }

   public float GetMoveSpeed()
   {
       return moveSpeed;
   }
}

