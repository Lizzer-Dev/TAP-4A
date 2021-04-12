package practicas.practicasjava.practica2;
import java.awt.*;
public class Contenedor extends Canvas {

    /**
     *
     */
    private static final long serialVersionUID = 1L;
    private int posx,posy;
    private int weight,height;
    private String texto="Boton";
    private String texto2="I'm Cube";
    private boolean presionado;
    public Contenedor(){
        this.setBackground(Color.pink);
        posx=50;
        posy=60;
        weight=50;
        height=50;

    }

    public void paint(Graphics graficos){
        graficos.setColor(Color.GREEN);
        graficos.fillOval(50,400,weight, height);
        graficos.setColor(Color.BLACK);
        graficos.drawString(texto,50,400);
        graficos.setColor(Color.WHITE);
        graficos.fillRect(posx, posy, weight, height);
        graficos.setColor(Color.BLACK);
        graficos.fillOval(posx+10, posy+5,weight-30, height-30);
        graficos.fillOval(posx+30, posy+5,weight-30, height-30);
        graficos.drawString(texto2,posx,posy);
        

    }
    public void setTexto1(String txt){
        this.texto=txt;
    }
    public void setTexto2(String txt){
        this.texto2=txt;
    }
    public void setPresionado(){
        this.presionado=!presionado;
    }
    public boolean getPresionado(){
        return presionado;
    }
    public void setPosX(int x){
        this.posx=x;
    }
    public int getPosx(){
        return posx;
    }
    public void setPosY(int y){
        this.posy=y;
    }
    public int getPosy(){
        return posy;
    }
    public void setWeight(int w){
        this.weight=w;
    }
    public int getWeight(){
        return weight;
    }
    public void setHeight(int h){
        this.height=h;
    }
    public int getHeight(){
        return height;
    }
}
