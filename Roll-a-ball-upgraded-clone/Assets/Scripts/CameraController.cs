using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerController player;
	private Vector3 offset;
    internal Vector3 previousPosition;



	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
        previousPosition = transform.position;
        transform.position = player.transform.position + offset;
    //    float chaseAngle = Vector3.SignedAngle(transform.position - previousPosition, transform.forward, Vector3.up);
        print(transform.InverseTransformDirection(player.GetComponent<Rigidbody>().velocity));
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * 90, Space.World);
    //    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.InverseTransformDirection(player.GetComponent<Rigidbody>().velocity).x * transform.InverseTransformDirection(player.GetComponent<Rigidbody>().velocity).z, transform.eulerAngles.z);
    //    transform.eulerAngles = Vector3.up * player.GetComponent<Rigidbody>().velocity.magnitude;
    //    transform.eulerAngles = Vector3.up * Input.GetAxis("Horizontal") * Input.GetAxis("Vertical") * 90;
    }
}