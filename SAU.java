package labeTechProg;
import java.awt.Color;
import java.awt.Graphics;

public class SAU {
	private int _startPosX;
    private int _startPosY;
    private int _pictureWidth;
    private int _pictureHeight;
    final private int etWidth = 90;
    final private int etHeight = 50;
    public int MaxSpeed;
    public float Weight;
    public Color MainColor;
    public Color DopColor;
    public Color FlagColor;
    public boolean DopKoleso;
    public boolean Phara;
    public boolean BackTube;
    
    private Cannon cannon;
    
    public SAU(int d, int e, Color mainColor, 
        Color dopColor, Color flagColor, boolean dopKoleso, boolean phara)
    {
        MaxSpeed = d;
        Weight = e;
        MainColor = mainColor;
        DopColor = dopColor;
        FlagColor = flagColor;
        DopKoleso = dopKoleso;
        Phara = phara;
        cannon = new Cannon((int)(Math.random() * 3)+1);
    }

    public void SetPosition(int x, int y, int width, int height)
    {
        _startPosX = x;
        _startPosY = y;
        _pictureWidth = width;
        _pictureHeight = height;
    }

    public void MoveTransport(Direction direction)
    {
        float step = MaxSpeed * 100 / Weight;
        switch (direction) {
            case Right:
                if (_startPosX + step < _pictureWidth - etWidth) {
                    _startPosX += step;
                }
                break;
            case Left:
                if (_startPosX - step > 5) {
                    _startPosX -= step;
                }
                break;
            case Up:
                if (_startPosY - step > 0)
                {
                    _startPosY -= step;
                }
                break;
            case Down:
                if (_startPosY + step < _pictureHeight - etHeight)
                {
                    _startPosY += step;
                }
                break;
        }
    }

    public void DrawSAU(Graphics g)
    {
        g.setColor(Color.BLACK);
        g.drawLine(_startPosX, _startPosY - 6, _startPosX - 5, _startPosY + 2);
        g.drawLine(_startPosX + 90, _startPosY - 6, _startPosX + 95, _startPosY + 2);

        g.fillOval(_startPosX + 2, _startPosY - 13, 20, 20);
        if (DopKoleso)
            g.fillOval( _startPosX + 24, _startPosY - 13, 20, 20);
        g.fillOval( _startPosX + 67, _startPosY - 13, 20, 20);

        g.setColor(DopColor);
        g.fillRect( _startPosX + 5, _startPosY - 25, 40, 19);

        g.setColor(MainColor);
        g.fillRect( _startPosX + 45, _startPosY - 35, 25, 29);
        g.fillRect( _startPosX + 70, _startPosY - 27, 20, 21);
        g.fillRect( _startPosX + 10, _startPosY - 33, 28, 10);

        g.setColor(Color.BLACK);

        g.fillOval( _startPosX, _startPosY - 10, 90, 4);

        g.drawRect( _startPosX + 45, _startPosY - 35, 45, 29);

         if (Phara)
             g.fillRect(_startPosX + 80, _startPosY - 20, 10, 5);
         
         cannon.DrawCannon(g, DopColor, _startPosX, _startPosY);

    }
}
