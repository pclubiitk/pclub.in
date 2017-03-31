/// <summary>
/// Touch screen value. the touch screen controller System : Using one per Touch area
/// </summary>

using UnityEngine;
using System.Collections;

public class TouchScreenVal {
	
	public Rect AreaTouch;
	private Vector2 controllerPositionTemp;
	private Vector2 controllerPositionNext;	
	
	// Define the area
	public TouchScreenVal(Rect position){
		AreaTouch = position;
		slideVal = new Vector2(AreaTouch.xMin,AreaTouch.yMin);
	}
	// on Press 
	public bool OnTouchPress(){
		bool res = false;
		for (var i = 0; i < Input.touchCount; ++i) {
			Vector2 touchpos = Input.GetTouch(i).position;
			if(touchpos.x >= AreaTouch.xMin && touchpos.x <= AreaTouch.xMax && touchpos.y >= AreaTouch.yMin && touchpos.y <= AreaTouch.yMax){
				slideVal.x = (1.0f/AreaTouch.xMax) * (touchpos.x - AreaTouch.xMin);
				slideVal.y = (1.0f/AreaTouch.yMax) * (touchpos.y - AreaTouch.yMin);
				if (Input.GetTouch(i).phase == TouchPhase.Began || Input.GetTouch(i).phase == TouchPhase.Stationary){
                	res = true;
				}
			}
        }
		return res;
	}
	// on Press and move
	public Vector2 slideVal = Vector2.zero;
	
	public Vector2 OnTouchDirection(bool fixdrag){
		Vector2 direction = Vector2.zero;
		for (var i = 0; i < Input.touchCount; ++i) {
			Vector2 touchpos = Input.GetTouch(i).position;
			if(touchpos.x >= AreaTouch.xMin && touchpos.x <= AreaTouch.xMax && touchpos.y >= AreaTouch.yMin && touchpos.y <= AreaTouch.yMax){
				slideVal.x = (1.0f/AreaTouch.xMax) * (touchpos.x - AreaTouch.xMin);
				slideVal.y = (1.0f/AreaTouch.yMax) * (touchpos.y - AreaTouch.yMin);
				if(Input.GetTouch(i).phase == TouchPhase.Began){
					controllerPositionNext = new Vector2(Input.GetTouch(i).position.x,Screen.height - Input.GetTouch(i).position.y);
					controllerPositionTemp = controllerPositionNext;
				}else{
					controllerPositionNext = new Vector2(Input.GetTouch(i).position.x,Screen.height - Input.GetTouch(i).position.y);
					Vector2 deltagrag = (controllerPositionNext-controllerPositionTemp);
					direction.x	+= deltagrag.x;
					direction.y	-= deltagrag.y;
					if(fixdrag)//if true will spring back to the first position after pressed. feel like joystick
					controllerPositionTemp = Vector2.Lerp(controllerPositionTemp,controllerPositionNext,0.5f);
				}	
			}
        }
		direction.Normalize();
		return direction;
	}
	
	public Vector2 OnDragDirection(bool fixdrag){
		Vector2 direction = Vector2.zero;
		for (var i = 0; i < Input.touchCount; ++i) {
			Vector2 touchpos = Input.GetTouch(i).position;
			if(touchpos.x >= AreaTouch.xMin && touchpos.x <= AreaTouch.xMax && touchpos.y >= AreaTouch.yMin && touchpos.y <= AreaTouch.yMax){
				slideVal.x = (1.0f/AreaTouch.xMax) * (touchpos.x - AreaTouch.xMin);
				slideVal.y = (1.0f/AreaTouch.yMax) * (touchpos.y - AreaTouch.yMin);
				
				if(Input.GetTouch(i).phase == TouchPhase.Began){
					controllerPositionNext = new Vector2(Input.GetTouch(i).position.x,Screen.height - Input.GetTouch(i).position.y);
					controllerPositionTemp = controllerPositionNext;
				}else{
					controllerPositionNext = new Vector2(Input.GetTouch(i).position.x,Screen.height - Input.GetTouch(i).position.y);
					Vector2 deltagrag = (controllerPositionNext-controllerPositionTemp);
					direction.x	= deltagrag.x;
					direction.y	= deltagrag.y;
					if(fixdrag)// if true will spring back to the first position after pressed. feel like joystick
					controllerPositionTemp = Vector2.Lerp(controllerPositionTemp,controllerPositionNext,0.5f);
				}	
			}
        }
		return direction;
	}

	// Draw Button GUI if  Textures are included.
	public void Draw(Texture2D circle,bool bg){
		if(bg){
			GUI.DrawTexture(AreaTouch,circle);
		}
		GUI.DrawTexture(new Rect(controllerPositionNext.x-25,controllerPositionNext.y-25,50,50),circle);
		GUI.DrawTexture(new Rect(controllerPositionTemp.x-25,controllerPositionTemp.y-25,50,50),circle);
	}
	
	public void DrawSlider(Texture2D bar,Texture bg,int btW,int btH){
		GUI.DrawTexture(AreaTouch,bg);
		GUI.DrawTexture(new Rect(slideVal.x,slideVal.y,btW,btH),bar);
	}

}
