using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraMovement : MonoBehaviour{
    public Camera cam;
    public float zoomSpeed;
    public float keyMoveSpeed;
    public float mouseMoveSpeed;
    public int border;
    private Vector3 holdPosition;
    public float middleMouseMovement;
    public GameObject point;


	void Update (){
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * Time.deltaTime * keyMoveSpeed;
        pos.y += Input.GetAxis("Vertical") * Time.deltaTime * keyMoveSpeed;

        if(Input.mousePosition.y >= Screen.height - border){
            pos.y += Time.deltaTime * mouseMoveSpeed;
        }
        else if(Input.mousePosition.y <= border) {
            pos.y -= Time.deltaTime * mouseMoveSpeed;
        }

        if(Input.mousePosition.x >= Screen.width - border){
            pos.x += Time.deltaTime * mouseMoveSpeed;
        }
        else if(Input.mousePosition.x <= border){
            pos.x -= Time.deltaTime * mouseMoveSpeed;
        }

        transform.position = pos;

        cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");

        if(Input.GetButtonDown("Fire3")){
            holdPosition.x = Input.mousePosition.x;
            holdPosition.y = Input.mousePosition.y;
            point.active = true;
            point.transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
            point.transform.localScale = new Vector3(cam.orthographicSize - 0.5f * cam.orthographicSize,cam.orthographicSize - 0.5f * cam.orthographicSize);
            //point.transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));

        }

        if(Input.GetButton("Fire3")){
            transform.position += new Vector3(Input.mousePosition.x - holdPosition.x,Input.mousePosition.y - holdPosition.y) * Time.deltaTime * middleMouseMovement;
        }

        if(Input.GetButtonUp("Fire3")){
            point.active = false;
        }
    }
}
