package practicas.practicasjava.practica3;
import java.net.UnknownHostException;
import practicas.practicasjava.practica3.informacionweb.Consultador;

public class Main {
    public static void main(String[] args) {
        Consultador consultador=new Consultador();
        try {
            consultador.obtenerIP();
        } catch (UnknownHostException ex) {
            ex.printStackTrace();
        }
    }
}
