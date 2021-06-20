package comunicacion;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.List;

import logica.Jugador;
import logica.Tablero;
public class Atendedor extends Thread{
    Socket jugador;
    BufferedReader in;
    PrintWriter out;
    List<Socket> sockets;
    Tablero tablero;
    Jugador jugadorSystem;

    public Atendedor() throws IOException {
        jugadorSystem=new Jugador(1);
        jugadorSystem.my_Tablero.llenarTablero();
        //this.sockets = ss;
        //in = new BufferedReader(new InputStreamReader(jugador.getInputStream()));
        //out = new PrintWriter(jugador.getOutputStream());
    }
    public void setTableroCont(String[][] tab){
        jugadorSystem.my_Tablero.tableroContrincante(tab);
    }
    public String[][] getTablero(){
        return jugadorSystem.my_Tablero.tableroProp;
    }
    public void iniciar(){
        try {
            jugadorSystem.my_Tablero.arribarBarcoSystem();
            Thread.sleep(1000);
            jugadorSystem.my_Tablero.efectuarDisparosSystem();
        } catch (Exception e) {
            //TODO: handle exception
        }
    }
    public void run() {
        
    }
}
