package labeTechProg;
import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JPanel;

public class PanelSAU extends JPanel {
	
	SAU sau; 
	
	public void updateET(int width, int height) {
		sau = new SAU((int)(Math.random() * 200) + 100, (int)(Math.random() * 1000) + 1000, 
                Color.BLUE, Color.BLACK, Color.RED, true, true);
		sau.SetPosition((int)(Math.random() * 200) + 100, (int)(Math.random() * 100) + 150, width, height);
	}
	
	public void MoveTransport(Direction direction) {
		switch (direction) {
		case Right:
			sau.MoveTransport(Direction.Right);
			break;
		case Left:
			sau.MoveTransport(Direction.Left);
			break;
		case Up:
			sau.MoveTransport(Direction.Up);
			break;
		case Down:
			sau.MoveTransport(Direction.Down);
			break;
		}
	}
	
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		if (sau != null) {
			sau.DrawSAU(g);
		}
	}
}
