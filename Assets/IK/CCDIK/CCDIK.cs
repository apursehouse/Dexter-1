﻿using UnityEngine;

public class CCDIK : MonoBehaviour {
  public Transform Tooltip;
  public Transform Target;
  public CCDIKJoint[] joints;

  void Update() {
    for (int i = 0; i < 100; i++) {
      for (int j = 0; j < joints.Length; j++) {
        joints[j].Evaluate(Tooltip, Target, j < 2);
      }
    }
  }
}