﻿/*
Copyright ©2017. The University of Texas at Dallas. All Rights Reserved. 

Permission to use, copy, modify, and distribute this software and its documentation for 
educational, research, and not-for-profit purposes, without fee and without a signed 
licensing agreement, is hereby granted, provided that the above copyright notice, this 
paragraph and the following two paragraphs appear in all copies, modifications, and 
distributions. 

Contact The Office of Technology Commercialization, The University of Texas at Dallas, 
800 W. Campbell Road (AD15), Richardson, Texas 75080-3021, (972) 883-4558, 
otc@utdallas.edu, https://research.utdallas.edu/otc for commercial licensing opportunities.

IN NO EVENT SHALL THE UNIVERSITY OF TEXAS AT DALLAS BE LIABLE TO ANY PARTY FOR DIRECT, 
INDIRECT, SPECIAL, INCIDENTAL, OR CONSEQUENTIAL DAMAGES, INCLUDING LOST PROFITS, ARISING 
OUT OF THE USE OF THIS SOFTWARE AND ITS DOCUMENTATION, EVEN IF THE UNIVERSITY OF TEXAS AT 
DALLAS HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

THE UNIVERSITY OF TEXAS AT DALLAS SPECIFICALLY DISCLAIMS ANY WARRANTIES, INCLUDING, BUT 
NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR 
PURPOSE. THE SOFTWARE AND ACCOMPANYING DOCUMENTATION, IF ANY, PROVIDED HEREUNDER IS 
PROVIDED "AS IS". THE UNIVERSITY OF TEXAS AT DALLAS HAS NO OBLIGATION TO PROVIDE 
MAINTENANCE, SUPPORT, UPDATES, ENHANCEMENTS, OR MODIFICATIONS.
*/

using UnityEngine;
using System.Collections;

public class SimVive : MonoBehaviour {

	// Called at the end of the program initialization
	void Start () {

		// Get transform for Vive input devices
		Transform devices = GameObject.Find ("Vive Input").transform;

		// Turn on anything turned off by SteamVR 
		for (int i = 0; i < devices.childCount; i++) {
			devices.GetChild (i).gameObject.SetActive (true);
		}

		// Turn off all SteamVR components
		GameObject.Find ("Vive Input").GetComponent<SteamVR_ControllerManager> ().enabled = false;
		GameObject.Find ("Vive Controller (left)").GetComponent<SteamVR_TrackedObject> ().enabled = false;
		GameObject.Find ("Vive Controller (right)").GetComponent<SteamVR_TrackedObject> ().enabled = false;
		GameObject.Find ("Vive HMD").GetComponent<SteamVR_TrackedObject> ().enabled = false;
		GameObject.Find ("Vive Camera").GetComponent<SteamVR_Camera> ().enabled = false;
		GameObject.Find ("Vive Listener").GetComponent<SteamVR_Ears> ().enabled = false;
	}
}
