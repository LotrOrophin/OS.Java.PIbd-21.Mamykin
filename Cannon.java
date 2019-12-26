package labeTechProg;
import java.awt.Color;
import java.awt.Graphics;

public class Cannon {
	private CannonNumber cannonNumber;
	
	public Cannon(int n) {
		switch (n) {
		case 1:
			cannonNumber = CannonNumber.One;
			break;
		case 2:
			cannonNumber = CannonNumber.Two;
			break;
		case 3:
			cannonNumber = CannonNumber.Three;
			break;
		default:
			cannonNumber = CannonNumber.One;
			break;
		}
	}
	
	public void DrawCannon(Graphics g, Color color, int startPosX, int startPosY) {
		
		int num, r;
		
		switch (cannonNumber) {
		case One:
			num = 1;
			r = 15;
			break;
		case Two:
			num = 2;
			r = 11;
			break;
		case Three:
			num = 3;
			r = 9;
			break;
		default:
			num = 1;
			r = 14;
			break;
		}
		
		for (int j = 0; j < num; j++) {
			int i = 0;
	        while (i < 7)
	        {
	            g.drawLine(startPosX + r*j+10+i, startPosY - 25, startPosX + r*j+36+i, startPosY - 90);
	            i++;
	        }
			
		}
	}
}
