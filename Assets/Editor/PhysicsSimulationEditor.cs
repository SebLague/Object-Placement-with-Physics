using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PhysicsSimulation))]
public class PhysicsSimulationEditor : Editor {

	public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        PhysicsSimulation sim = (PhysicsSimulation)target;

        if (GUILayout.Button("Simulate"))
        {
            sim.RunSimulation();
        }

		if (GUILayout.Button("Reset"))
		{
            sim.ResetAllBodies();
		}
    }

}
