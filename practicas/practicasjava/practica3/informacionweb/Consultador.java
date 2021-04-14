package practicas.practicasjava.practica3.informacionweb;
import java.net.*;
import java.net.InetAddress;
import java.net.UnknownHostException;
import java.util.logging.Level;
import java.util.logging.Logger;
public class Consultador {
    static private final Logger LOGGER = Logger.getLogger("www.itescam.edu.mx");

    public String obtenerIP() throws UnknownHostException {
        InetAddress ip = InetAddress.getByName("www.itescam.edu.mx");
        System.out.println(ip.getHostName());
        return ip.getHostAddress();
    }

    public URLConnection obtenerDocumento()throws MalformedURLException,UnknownHostException{
        URL url=new URL(obtenerIP(),"www.itescam.edu.mx","index.html");
        //return url.openConnection();
    }
    
    public static void main(String[] args) {
        try {
            Consultador consultador = new Consultador();
            System.out.println("La IP de la pagina es " + consultador.obtenerIP());
            System.out.println(consultador.obtenerDocumento());
        } catch (UnknownHostException ex) {
            LOGGER.log(Level.SEVERE, "Error al consultar el Host");
            LOGGER.log(Level.SEVERE, null, ex);
        } catch(Exception E){

        }       
    }    
}
